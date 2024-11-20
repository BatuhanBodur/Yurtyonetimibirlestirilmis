using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Ogrenci;

public class YemekListesiController : Controller {

    public IActionResult Yemek() {
        return View();
    }

}