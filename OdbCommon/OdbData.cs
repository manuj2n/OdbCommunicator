﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdbCommunicator.OdbCommon
{
    public class OdbData
    {
        public string[] Header { get; set; }
        public string[] Info { get; set; }
        public string[] Data { get; set; }
        public string[] Ender { get; set; }

        /// <summary>
        /// Length of while data response
        /// </summary>
        public int DataLength { get; set; }

        /// <summary>
        /// Protocol
        /// </summary>
        public OdbPid Protocol { get; set; }

        /// <summary>
        /// Get ecu identifier header
        /// </summary>
        /// <returns></returns>
        public int EcuIdentifier()
        {
            var header = String.Join("", this.Header);
            if (String.IsNullOrWhiteSpace(header)) 
            {
                return 0;
            }
            return Convert.ToInt32(header, 16);
        }
    }
}
