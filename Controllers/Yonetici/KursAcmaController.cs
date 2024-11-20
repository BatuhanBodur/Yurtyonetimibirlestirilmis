using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Yonetici;

public class KursAcmaController : Controller {

    public IActionResult Kurs() {
        return View();
    }

}