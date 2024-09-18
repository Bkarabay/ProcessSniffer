using PacketDotNet;
using SharpPcap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSniffer
{
    public class PacketSniffer
    {
        private byte[] previousPayloadData = null;
        private ColorFilter colorFilter = new ColorFilter();

        private ICaptureDevice device;
        public void StartCapture()
        {
            var devices = CaptureDeviceList.Instance;
            if (devices.Count < 1)
            {
                Console.WriteLine("No devices found.");
                return;
            }
            var device = devices[Config.GetConfig().DeviceID];
            device.OnPacketArrival += new PacketArrivalEventHandler(Device_OnPacketArrival);
            device.Open(DeviceModes.Promiscuous);
            device.StartCapture();

        }

        public void StopCapture()
        {
            if (device != null && device.Started)
            {
                device.StopCapture();
                device.Close();
            }
        }
        private void Device_OnPacketArrival(object sender, PacketCapture e)
        {
            var packet = Packet.ParsePacket(e.GetPacket().LinkLayerType, e.GetPacket().Data);
            var ipPacket = packet.Extract<IPPacket>();

            if (ipPacket != null)
            {
                var tcpPacket = ipPacket.Extract<TcpPacket>();
                if (tcpPacket != null)
                {
                    if (tcpPacket.SourcePort == Config.GetConfig().PortNumber)
                    {
                        byte[] payloadData = tcpPacket.PayloadData;

                        Console.WriteLine($"Payload Length: {payloadData.Length} bytes");
                        string payloadString = Encoding.UTF8.GetString(payloadData);
                        Console.WriteLine($"Convert UTF8: {payloadString}");

                        Console.WriteLine($"TCP Data: " + BitConverter.ToString(payloadData));

                        colorFilter.PrintColoredUdpData(payloadData, previousPayloadData);

                        previousPayloadData = (byte[])payloadData.Clone();
                    }
                }
            }
        }


    }
}
