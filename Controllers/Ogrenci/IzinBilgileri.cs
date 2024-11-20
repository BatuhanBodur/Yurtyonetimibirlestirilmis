using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Ogrenci;

public class IzinBilgileri : Controller {

    public IActionResult Izin() {
        return View();
    }

}