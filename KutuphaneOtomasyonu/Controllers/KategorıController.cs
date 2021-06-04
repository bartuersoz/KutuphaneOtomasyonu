using KutuphaneProgramı.Data;
using System.Linq;
using System.Web.Mvc;

namespace KutuphaneOtomasyonu.Controllers
{
    public class KategorıController : Controller
    {
        // GET: Kategorı
        public ActionResult Index()
        {
            Context context = new Context();
            // = context.Kitaplar.ToList();
            return View();
        }
    }
}