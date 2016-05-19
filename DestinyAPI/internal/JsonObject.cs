using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyAPI
{
    internal abstract class JsonObject
    {
        
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public String ErrorStatus { get; set; }
        public String Message { get; set; }
        public object MessageData { get; set; }
    }
}
