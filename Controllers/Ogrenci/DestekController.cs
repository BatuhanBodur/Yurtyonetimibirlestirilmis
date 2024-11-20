using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Ogrenci;

public class DestekController : Controller {

    public IActionResult Supported() {
        return View();
    }

}