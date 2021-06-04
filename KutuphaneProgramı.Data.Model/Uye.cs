using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProgramı.Data.Model
{
   public class Uye:BaseEntity      

    {
        public String Ad { get; set; }
        public String SoyAd { get; set; }
        public String Tc { get; set; }

        public String Tel { get; set; }

        public DateTime KayitTarihi { get; set; }

        public String Mail { get; set; }

        public String Sire { get; set; }

        public int Ceza { get; set; }

        public Char Yetki { get; set; }

        public List<OduncAlinan> OduncKitaplar { get; set; }
    }
}
