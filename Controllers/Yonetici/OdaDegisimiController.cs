using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Yonetici;

public class OdaDegisimiController : Controller {

    public IActionResult Degisim() {
        return View();
    }

}