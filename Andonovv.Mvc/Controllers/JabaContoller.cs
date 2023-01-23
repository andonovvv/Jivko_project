using Andonov_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Andonov_mvc.Controllers
{
    public class KucheContoller : Controller
    {
        public IActionResult index()
        {
            List<Kuche> Kuche = new List<Kuche>()
            {
                new Kuche() { KucheId = 2, Poroda = "huski", Vid = "sredno", YearBorn = 2018}
            };
            return View(Kucheta);
        }
    }
}
