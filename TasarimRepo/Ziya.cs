using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasarimRepo
{
   internal class Ziya
    {
        public string isimsoyisim { get; set; }
        public string ogrenciisimsoyisim { get; set; }
        public string  sınıf { get; set; }
        public string gelişamacı { get; set; }
        public string gidilecek { get; set; }
        public string velimi { get; set; }



        public Ziya()
        {
            
        }

        public Ziya(string isimsoyisim, string ogrenciisimsoyisim, string sınıf,string gelişamacı, string gidilecek,string velimi)
        {
            this.isimsoyisim = isimsoyisim;
            this.ogrenciisimsoyisim = ogrenciisimsoyisim;
            this.sınıf = sınıf;
            this.gelişamacı = gelişamacı;
            this.gidilecek = gidilecek;
            this.velimi = velimi;
            
        }
    }
}
