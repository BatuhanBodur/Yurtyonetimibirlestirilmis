using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Ogrenci;

public class YurtIletisimController : Controller {

    public IActionResult Iletisim() {
        return View();
    }

}