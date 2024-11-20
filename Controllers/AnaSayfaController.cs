using Microsoft.AspNetCore.Mvc;

namespace MVC_YURT.Controllers;

public class AnaSayfaController : Controller
{
    public IActionResult Index()
    {
         // Kullanıcının rolünü oturumdan al
        string userRole = HttpContext.Session.GetString("UserRole") ?? "Student";
    
        // Rol bilgisi görünümde kullanılacak
        ViewBag.UserRole = userRole;
        
        return View();
    }
    
}
