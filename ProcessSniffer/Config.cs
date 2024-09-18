using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSniffer
{
    public sealed class Config
    {
        private Config() { }
        private static Config _config;

        public int DeviceID { get; set;}
        public int PortNumber { get; set;}
        public string packetType { get; set;}
        public bool colorchanges {  get; set;}

        public static Config GetConfig()
        {
            if(_config == null)
            {
                _config = new Config();
            }

            return _config;
        }

    }
}
