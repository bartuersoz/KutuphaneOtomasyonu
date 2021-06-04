using System;
using System.Collections.Generic;

namespace KutuphaneProgramı.Data.Model
{
    public class Kıtap:BaseEntity       
    {
        public string Kitapad { get; set; }
        public string SiraNo { get; set; }
        public int Adet { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }
        public List<Kategorı> Kategoriler { get; set; }

    }
}
