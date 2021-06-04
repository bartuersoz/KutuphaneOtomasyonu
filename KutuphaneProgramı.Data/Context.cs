using KutuphaneProgramı.Data.Model;
using System.Data.Entity;

namespace KutuphaneProgramı.Data
{
    public class Context:DbContext
    {
        public Context():base("Context")
        {

        }
        public DbSet <Kategorı>Kategoriler{ get; set; }
        public DbSet<Kıtap> Kitaplar { get; set; }
        public DbSet<Uye> Uyeler { get; set; }

        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<OduncAlinan> OduncKitaplar { get; set; }

    }
}
