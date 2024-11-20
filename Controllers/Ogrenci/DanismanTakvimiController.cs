using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Ogrenci;

public class DanismanTakvimiController : Controller {

    public IActionResult Danisman() {
        return View();
    }

}