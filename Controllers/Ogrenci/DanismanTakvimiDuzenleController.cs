using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Ogrenci;

public class DanismanTakvimiDuzenleController : Controller {

    public IActionResult DanismanTakvim() {
        return View();
    }

}