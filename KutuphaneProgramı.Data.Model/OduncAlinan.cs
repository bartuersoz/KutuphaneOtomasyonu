using System;

namespace KutuphaneProgramı.Data.Model
{
    public class OduncAlinan:BaseEntity
    {
        public int KitapId { get; set; }

        public int UyeId { get; set; }

        public DateTime AlisTarihi { get; set; }

        public DateTime GetirecegiTarih { get; set; }

        public DateTime? GetirdigiTarih { get; set; }


    }
}
