using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataControlApp
{
   public class Seçilenİdare
    {
        public int idaresirano { get; set; }
        public string idareisim { get; set; }
        public string idaresoyisim { get; set; }
        public string görev { get; set; }
        public int idaredoğumtar { get; set; }
        public bool idaremüsaitlikdurumu { get; set; }

        public Seçilenİdare()
        {

        }

        public Seçilenİdare(int idaresirano, string idareisim, string idaresoyisim, string görev, int idaredoğumtar)
        {
            this.idaresirano = idaresirano;
            this.idareisim = idareisim;
            this.idaresoyisim = idaresoyisim;
            this.görev = görev;
            this.idaredoğumtar = idaredoğumtar;
        }
    }
}
