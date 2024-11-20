using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Yonetici;

public class OdemeDurumuController : Controller {

    public IActionResult Odeme() {
        return View();
    }

}