using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers.Ogrenci;

public class OgrenciProfiliController : Controller {

    public IActionResult Profil() {
        return View();
    }

}