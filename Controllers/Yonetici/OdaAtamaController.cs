using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Yonetici;

public class OdaAtamaController : Controller {

    public IActionResult Atama() {
        return View();
    }

}