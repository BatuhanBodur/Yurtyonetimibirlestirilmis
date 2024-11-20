using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Yonetici;

public class OdaBilgileriController : Controller {

    public IActionResult Bilgi() {
        return View();
    }

}