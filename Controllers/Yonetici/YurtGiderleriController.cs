using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Yonetici;

public class YurtGiderleriController : Controller {

    public IActionResult Gider() {
        return View();
    }

}