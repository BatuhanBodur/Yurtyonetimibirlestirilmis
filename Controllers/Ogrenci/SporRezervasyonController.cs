using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Ogrenci;

public class SporRezervasyonController : Controller {

    public IActionResult Rezervasyon() {
        return View();
    }

}