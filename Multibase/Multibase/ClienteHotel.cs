using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multibase
{
    public class ClienteHotel
    {
   
        public string nombre{ get; set; }
        public string apPat { get; set; }
        public string apMat { get; set; }

        public ClienteHotel(string n, string ap, string am) {

            nombre = n;
            apPat = ap;
            apMat = am;

        }
        public ClienteHotel()
        {

        }
    }
}
