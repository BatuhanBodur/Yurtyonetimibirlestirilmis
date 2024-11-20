using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Ogrenci;

public class OdaDegisikligiController : Controller {

    public IActionResult Oda() {
        return View();
    }

}