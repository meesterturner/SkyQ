using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyQLib
{
    public class PvrList
    {
        public string documentId { get; set; }
        public int offset { get; set; }
        public List<PvrItem> pvrItems { get; set; }
        public int totalPvrItems { get; set; }
        public int version { get; set; }
    }
}
