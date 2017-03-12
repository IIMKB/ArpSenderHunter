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
using System.Diagnostics;

namespace ARP
{
    public partial class ARP : Form
    {
        //14字节以太网首部
        //public class EthernetHeader
        //{
        //    public byte[] DestMac = new byte[6] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };//目的MAC地址 6字节
        //    public byte[] SourMAC = new byte[6] { 0x60, 0xD8, 0x19, 0x51, 0x6F, 0xC5 };//源MAC地址 6字节
        //    public ushort EthType = 0x0806;//上一层协议类型，如0x0800代表上一层是IP协议，0x0806为arp  2字节
        //};
        ////28字节ARP帧结构
        //public class ArpHeader
        //{
        //    public ushort hdType = 0x0001;//硬件类型
        //    public ushort proType = 0x0800;//协议类型 IP协议固定
        //    public byte hdSize = 0x06;//硬件地址长度 MAC
        //    public byte proSize = 0x04;//协议地址长度 IP 32位4byte
        //    public ushort op = 0x0001; //操作类型，ARP请求（1），ARP应答（2），RARP请求（3），RARP应答（4）
        //    public byte[] smac = new byte[6] { 0x60, 0xD8, 0x19, 0x51, 0x6F, 0xC5 };//源MAC地址
        //    public byte[] sip = new byte[4] { 0xC0, 0xA8, 0x01, 0xC7 };//源IP地址
        //    public byte[] dmac = new byte[6] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };//目的MAC地址
        //    public byte[] dip = new byte[4] { 0xC0, 0xA8, 0x01, 0x01 };//目的IP地址
        //};
        ////定义整个arp报文包，总长度42字节
        //public class ArpPacket
        //{
        //    EthernetHeader ed;
        //    ArpHeader ah;
        //};
        byte[] arp = new byte[60]{0xff,0xff,0x2f,0xff,0xff,0xff,0x60,0xd8,0x19,0x51,0x6f,0xc5,0x08,0x06,0x00,0x01,
                                       0x08,0x00,0x06,0x04,0x00,0x01,0x60,0xd8,0x19,0x51,0x6f,0xc5,0xc0,0xa8,0x01,0xc7,
                                       0xff,0xff,0xff,0xff,0xff,0xff,0xc0,0xa8,0x02,0x03,
                                       0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00};

        public ARP()
        {
            InitializeComponent();
            
        }

        private void cmbNetCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbNetCard.SelectedIndex;
            textBox1.AppendText("当前网络设备："+ LibPcapLiveDeviceList.Instance[i].Name + "\r\n");
        }

        private void ARP_Load(object sender, EventArgs e)
        {
            var devices = LibPcapLiveDeviceList.Instance;
            // If no devices were found print an error
            if (devices.Count < 1)
            {
                MessageBox.Show("No devices were found on this machine!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cmbNetCard.DataSource = devices;
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int idev = cmbNetCard.SelectedIndex;
            var devices = LibPcapLiveDeviceList.Instance;
            var dev = devices[idev];
            dev.Open(DeviceMode.Promiscuous, 1000);
            string strDesmac = txtMACto.Text;
            string strSourmac = txtMACfrom.Text;
            //Regex r = new Regex(@"^([0-9A-F][0-9A-F]-[0-9A-F][0-9A-F]-[0-9A-F][0-9A-F]-[0-9A-F][0-9A-F]-[0-9A-F][0-9A-F]-[0-9A-F][0-9A-F])$");
            if (Regex.IsMatch(strDesmac, @"^(?in)([\da-f]{2}(-|$)){6}$") && Regex.IsMatch(strSourmac, @"^(?in)([\da-f]{2}(-|$)){6}$"))
            {
                //MessageBox.Show("正确");          
                byte[] DesMac = new byte[6];
                byte[] SourMac = new byte[6];
                strDesmac = strDesmac.Replace("-", "");
                strSourmac = strSourmac.Replace("-", "");
                List<string> DesDataList = new List<string>();
                List<string> SourDataList = new List<string>();
                for (int i = 0; i < strDesmac.Length; i = i + 2)
                {
                    DesDataList.Add(strDesmac.Substring(i, 2));
                    SourDataList.Add(strSourmac.Substring(i, 2));
                }
                DesMac = new byte[DesDataList.Count];
                SourMac = new byte[SourDataList.Count]; 
                //每两个字符放进一个字节
                for (int j = 0; j < DesMac.Length; j++)
                {
                    DesMac[j] = (byte)(Convert.ToInt32(DesDataList[j], 16));
                    SourMac[j] = (byte)(Convert.ToInt32(SourDataList[j], 16));
                }
                for (int imac = 0; imac < 6; imac++)//testexp:20-30-40-10-FF-12
                {
                    arp[imac] = DesMac[imac];
                    arp[imac + 32] = DesMac[imac];
                    arp[imac + 6] = SourMac[imac];                          
                    arp[imac + 22] = SourMac[imac];
                }
            }
            else
            {
                MessageBox.Show("MAC地址无效，请重新填写！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
                                         
            IPAddress ip;//.net
            if (IPAddress.TryParse(txtIPfrom.Text, out ip) && IPAddress.TryParse(txtIPfrom.Text, out ip))
            {
                
                byte[] DesIP = new byte[4];
                byte[] SourIP = new byte[4];
                string[] strSourIP;
                string[] strDesIP;
                char[] separator = new char[] { '.' };
                //ip地址分段写入
                strDesIP = txtIPto.Text.Split(separator);
                strSourIP = txtIPfrom.Text.Split(separator);
                
                //MessageBox.Show(" "+ strDesIP[1], "@");
                for (int ipi = 0; ipi < 4; ipi++)
                {
                    arp[ipi + 38] = (byte)(Convert.ToInt32(strDesIP[ipi], 10));
                    //MessageBox.Show(" "+ arp[ipi+38], "@");
                    arp[ipi + 28] = (byte)(Convert.ToInt32(strSourIP[ipi], 10)); 
                }

            }
            else
            {
                MessageBox.Show("IP地址无效，请重新填写！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //MessageBox.Show("@@" + arp[0], "@");
            dev.SendPacket(arp);
            textBox1.AppendText("发送成功！\r\n");
        }

        private void txtMACto_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdobRQ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobRQ.Checked == true)
            {
                rdobRP.Checked = false;
                arp[21] = 0x01;
            }
            else
            {
                rdobRP.Checked = true;
                arp[21] = 0x02;
            }
        }

        private void rdobRP_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Process p = Process.GetCurrentProcess();
            if (p != null)
            {
                p.Kill();
            }
            Application.ExitThread();
            Dispose();
            Application.Exit();
        }
        public ARPHunter arpH = null; 

        private void btnHunter_Click(object sender, EventArgs e)
        {
            if (arpH == null)
            {
                arpH = new ARPHunter();
                arpH.Show();
            }
            else
            {
                arpH.Close();
                arpH = null;
            }
            

        }

        private void ARP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process p = Process.GetCurrentProcess();
            if (p != null)
            {
                p.Kill();
            }
            Application.ExitThread();
            Dispose();
            Application.Exit();
        }
    }
}
