using Microsoft.AspNetCore.Mvc;

namespace PortalCursosBenedix.Application.Controllers
{
    public class AdministrativoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
