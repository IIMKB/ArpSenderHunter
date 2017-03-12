using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using SharpPcap.LibPcap;
using SharpPcap;
using ARP;
using System.Text.RegularExpressions;
using System.Net;
using System.Threading;
using SharpPcap.AirPcap;
using SharpPcap.WinPcap;
using System.Diagnostics;

namespace ARP
{
    public partial class ARPHunter : Form
    {
        public ARPHunter()
        {
            InitializeComponent();
        }

        
    private void ARPHunter_Load(object sender, EventArgs e)
        {

            var devices = CaptureDeviceList.Instance;

            // If no devices were found print an error
            if (devices.Count < 1)
            {
                MessageBox.Show("No devices were found on this machine!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cbmNetCard.DataSource = devices;
            //按钮逻辑
            if(cbmNetCard.Enabled)
            {
                btnStop.Enabled = false;
            }

            this.txtDetails.WordWrap = false;//横向滚动条显示
        }

        private void cbmNetCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbmNetCard.SelectedIndex;
            txtInfo.AppendText("当前网络设备：" + LibPcapLiveDeviceList.Instance[i].Name + "\r\n");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //按钮逻辑
            cbmNetCard.Enabled = false;
            btnStop.Enabled = true;
            btnStart.Enabled = false;

            var devices = CaptureDeviceList.Instance;
            int idev = cbmNetCard.SelectedIndex;
            var dev = devices[idev];
            dev.OnPacketArrival +=
                new PacketArrivalEventHandler(device_OnPacketArrival);
            int readTimeoutMilliseconds = 1000;
            if (dev is AirPcapDevice)
            {
                // NOTE: AirPcap devices cannot disable local capture
                var airPcap = dev as AirPcapDevice;
                airPcap.Open(SharpPcap.WinPcap.OpenFlags.DataTransferUdp, readTimeoutMilliseconds);
            }
            else if (dev is WinPcapDevice)
            {
                var winPcap = dev as WinPcapDevice;
                winPcap.Open(SharpPcap.WinPcap.OpenFlags.DataTransferUdp | SharpPcap.WinPcap.OpenFlags.NoCaptureLocal, readTimeoutMilliseconds);
            }
            else if (dev is LibPcapLiveDevice)
            {
                var livePcapDevice = dev as LibPcapLiveDevice;
                livePcapDevice.Open(DeviceMode.Promiscuous, readTimeoutMilliseconds);
            }
            else
            {
                txtInfo.AppendText("unknown device type of " + dev.GetType().ToString());
                return;
            }

            txtInfo.AppendText("-- 开始捕捉！"+"\r\n");
            txtInfo.AppendText("-- 设备名称："+dev.Name+" \r\n描述信息："+ dev.Description+"\r\n");
            // Start the capturing process
            dev.StartCapture();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //按钮逻辑
            cbmNetCard.Enabled = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            var devices = CaptureDeviceList.Instance;
            if (devices.Count < 1)
            {
                MessageBox.Show("此设备上没有网卡！");
                return;
            }
                
            int idev = cbmNetCard.SelectedIndex;
            var dev = devices[idev];
            
            // Stop the capturing process
            dev.StopCapture();

            txtInfo.AppendText("-- 停止捕捉.\r\n");
            // Print out the device statistics
            txtInfo.AppendText(dev.Statistics.ToString()+"\r\n");

            // Close the pcap device
            dev.Close();
            txtInfo.AppendText("--关闭设备\r\n");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lisvARP.Items.Clear();  //只移除所有的项。
            txtDetails.Clear();
            txtInfo.Clear();
        }
        private static int packetIndex = 0; //序号
        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
            this.Close();
        }
        public string[] arpHEX = new string[10000];
        private  void device_OnPacketArrival(object sender, CaptureEventArgs e)
        {
            var packet = PacketDotNet.Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);//基本包

            var arpPacket = PacketDotNet.ARPPacket.GetEncapsulated(packet);
            //var ipPacket = PacketDotNet.IpPacket.GetEncapsulated(packet); //ip包  
            //var udpPacket = PacketDotNet.UdpPacket.GetEncapsulated(packet);
            //var tcpPacket = PacketDotNet.TcpPacket.GetEncapsulated(packet);
            
            //txtDetails.AppendText("\r\n***协议类别："+dlPacket.ToString()+"****\r\n");
            if (arpPacket != null)
            {
                
                var time = DateTime.Now.ToString();
                var len = e.Packet.Data.Length;
                var dlPacket = PacketDotNet.DataLinkPacket.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);

                arpHEX[packetIndex] = arpPacket.PrintHex().ToString();
                lisvARP.Items.Add(new ListViewItem(new string[] {
                    packetIndex.ToString(),
                    arpPacket.Operation.ToString(),
                    time.ToString(),
                    len.ToString(),
                    arpPacket.SenderProtocolAddress.ToString(),
                    arpPacket.TargetProtocolAddress.ToString(),
                    arpPacket.SenderHardwareAddress.ToString(),
                    arpPacket.TargetHardwareAddress.ToString()

                }));

                //txtDetails.AppendText("\r\n*******************************************\r\n");
                //txtDetails.AppendText("\r\n编号    ：" + packetIndex + "!!!!\r\n");
                //txtDetails.AppendText("\r\n时间    ：" + time + "!!!!\r\n");
                //txtDetails.AppendText("\r\n长度    ：" + len + "!!!!\r\n");
                //txtDetails.AppendText("\r\n类型：" + arpPacket.GetType().ToString() + "!!!!\r\n");
                //txtDetails.AppendText("\r\n源IP地址：" + arpPacket.SenderProtocolAddress.ToString() + "!!!!\r\n");
                //txtDetails.AppendText("\r\n协议地址类型：" + arpPacket.ProtocolAddressType + "!!!!\r\n");
                //txtDetails.AppendText("\r\nHEX：" + arpHEX[packetIndex] + "!!!!\r\n");
                //txtDetails.AppendText("\r\n*******************************************\r\n");
                packetIndex++;
            }
                

            // txtDetails.AppendText("\r\n时间："+ DateTime.Now.ToLongTimeString() + "\r\n");
            // Console.WriteLine("{0}:{1}:{2},{3} Len={4}",time.Hour, time.Minute, time.Second, time.Millisecond, len);
            //txtDetails.AppendText(packetIndex+"\r\n");
            //txtDetails.AppendText(e.Packet.ToString()+"\r\n");
            
            // Console.WriteLine(e.Packet.ToString());

        }

        private void lisvARP_DoubleClick(object sender, EventArgs e)
        {
        }

        private void lisvARP_Click(object sender, EventArgs e)
        {
            txtDetails.Text = arpHEX[Convert.ToInt32(lisvARP.SelectedItems[0].Text.ToString())];
        }

        private void ARPHunter_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ARPHunter_FormClosing(object sender, FormClosingEventArgs e)
        {

            Dispose();
            this.Close();
        }
    }
}
