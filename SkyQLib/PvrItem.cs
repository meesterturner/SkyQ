using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyQLib
{
    public class PvrItem
    {
        public long ast { get; set; }
        public string at { get; set; }
        public string carating { get; set; } // BBFC Rating
        public string cn { get; set; } // Channel
        public string downloadlink { get; set; }
        public int eg { get; set; }
        public int esg { get; set; }
        public string et { get; set; } // HD/SD ?
        public long exp { get; set; } // Expiry ?
        public string fr { get; set; }
        public bool hd { get; set; } // HD Available
        public int lto { get; set; }
        public long predictedsz { get; set; }
        public string programmeuuid { get; set; }
        public string pvrid { get; set; }
        public string r { get; set; } // Rating again?
        public bool s { get; set; }
        public int schd { get; set; }
        public string src { get; set; } // e.g. VOD
        public string status { get; set; }
        public string sy { get; set; } // Synopsis
        public string t { get; set; } // Title
        public int tso { get; set; }
        public int vodprogrammeid { get; set; }
        public bool w { get; set; } // Widescreen??

        public override string ToString()
        {
            return this.t;
        }
    }
}
