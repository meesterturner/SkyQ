using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SkyQLib
{
    // https://gladdy.uk/blog/2017/03/13/skyq-upnp-rest-and-websocket-api-interfaces/

    public class Comms
    {
        public string IPAddress { get; set; }

        public PvrList GetPvrList()
        {
            string pvrJson;

            using (var client = new WebClient())
            {
                pvrJson = client.DownloadString(String.Format("http://{0}:9006/as/pvr?offset=0&limit=99999", IPAddress));
            }

            PvrList retVal = JsonConvert.DeserializeObject<PvrList>(pvrJson);

            return retVal;
        }
    }
}
