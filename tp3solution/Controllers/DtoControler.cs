using Microsoft.AspNetCore.Mvc;
using tp3solution.Models.Service;

namespace tp3solution.Controllers
{
    public class DtoControler : Controller
    {
        private readonly IdtoService __service;

        public DtoControler(IdtoService service)
        {
            __service = service;
        }
        public IActionResult Index()
        {
            var dto = __service.GetDto();
  
            return View(dto);
        }
    }
}
