using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PuppiesPet.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


       

    }
}
