using System.Collections.Generic;

namespace KutuphaneProgramı.Data.Model
{
    public class Kategorı: BaseEntity
    {
        public string Ad { get; set; }
        public List<Kıtap> Kıtaplar { get; set; }
        
    }
}
