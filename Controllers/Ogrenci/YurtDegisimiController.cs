using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Ogrenci;

public class YurtDegisimiController : Controller {

    public IActionResult Degisim() {
        return View();
    }

}