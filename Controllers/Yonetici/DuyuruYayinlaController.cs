using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Yonetici;

public class DuyuruYayinlaController : Controller {

    public IActionResult Duyurular() {
        return View();
    }

}