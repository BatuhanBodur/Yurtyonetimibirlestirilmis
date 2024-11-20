using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Yonetici;

public class GuvenlikPersonelController : Controller {

    public IActionResult Personel() {
        return View();
    }

}