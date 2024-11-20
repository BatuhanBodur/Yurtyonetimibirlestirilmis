using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Yonetici;

public class OgrenciDevamsizlikController : Controller {

    public IActionResult Devamsizlik() {
        return View();
    }

}