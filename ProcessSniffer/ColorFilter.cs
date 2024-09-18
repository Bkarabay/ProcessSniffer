using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSniffer
{
    public class ColorFilter
    {
        public void PrintColoredUdpData(byte[] payloadData, byte[] previousPayloadData)
        {
            if (previousPayloadData == null)
            {
                Console.WriteLine(payloadData);
            }
            else
            {
                for (int i = 0; i < payloadData.Length; i++)
                {
                    if (i < previousPayloadData.Length && payloadData[i] != previousPayloadData[i])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{payloadData[i]:X2}-");
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write($"{payloadData[i]:X2}-");
                    }
                }
                Console.WriteLine();
                Console.ResetColor();
            }
            previousPayloadData = (byte[])payloadData.Clone();
        }
    }
}
