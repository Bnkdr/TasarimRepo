using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasarimRepo
{
    internal class Nöbetçi
    {
        public int key { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string sınıf { get; set; }
        public string no { get; set; }
        public string sirano { get; set; }


        public Nöbetçi()
        {
            
        }

        public Nöbetçi(int key, string isim, string soyisim, string sınıf, string no,string sirano)
        {
            this.key = key;
            this.isim = isim;
            this.soyisim = soyisim;
            this.sınıf = sınıf;
            this.no = no;
            this.sirano = sirano;
        }
    }
}
