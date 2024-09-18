using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProcessSniffer
{
    public class Processport
    {

        private int processID;
        private int ports;

        public enum PacketType
        {
            TCP,
            UDP
        }
        private int GetProcessID(string processName) 
        {
            var process = Process.GetProcessesByName(processName);
            foreach (var p in process)
            {
                processID = p.Id;
            }

            return processID; 
        }

        public int ListPorts(string processName)
        {
            int processID = GetProcessID(processName);
            return ListPortsByProcessID(processID);
        }
        public int ListPorts(int ProcessID)
        {
            return ListPortsByProcessID(ProcessID);

        }
        private int ListPortsByProcessID(int processID)
        {
            var processPorts = GetProcessPorts(processID);
            return processPorts.LastOrDefault();
        }
        private static List<int> GetProcessPorts(int processId)
        {
            var processPorts = new List<int>();
            string netstatOutput = GetNetstatOutput();
            var packetType = GetPacketTypeFromConfig();
            string pattern = GetRegexPattern(packetType, processId);
            foreach (Match match in Regex.Matches(netstatOutput, pattern))
            {
                if (int.TryParse(match.Groups[1].Value, out int port))
                {
                    processPorts.Add(port);
                }
            }

            return processPorts;
        }

        private static PacketType GetPacketTypeFromConfig()
        {
            string packetTypeString = Config.GetConfig().packetType;

            if (Enum.TryParse(packetTypeString, true, out PacketType packetType))
            {
                return packetType;
            }

            throw new InvalidOperationException($"Invalid packet type: {packetTypeString}");
        }

        private static string GetRegexPattern(PacketType packetType, int processId)
        {
            return packetType switch
            {
                PacketType.TCP => $@"\s+TCP\s+[\d\.]+:(\d+)\s+[\d\.]+:\d+\s+ESTABLISHED\s+{processId}",
                PacketType.UDP => $@"\s+UDP\s+[\d\.]+:(\d+)\s+[\d\.]+:\d+\s+{processId}",
                _ => throw new InvalidOperationException($"Unsupported packet type: {packetType}")
            };
        }

        private static string GetNetstatOutput()
        {
            Process netstatProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "netstat",
                    Arguments = "-a -n -o",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            netstatProcess.Start();
            string output = netstatProcess.StandardOutput.ReadToEnd();
            netstatProcess.WaitForExit();

            return output;
        }

    }
}
