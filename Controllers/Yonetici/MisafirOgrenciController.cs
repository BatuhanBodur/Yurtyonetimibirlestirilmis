using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Yonetici;

public class MisafirOgrenciController : Controller {

    public IActionResult Misafir() {
        return View();
    }

}