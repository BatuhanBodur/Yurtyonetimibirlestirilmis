using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MVC_YURT.Controllers;

public class GirisEkraniController : Controller
{

    [HttpGet]
    public IActionResult Giris()
    {
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> CheckUsers(string username, string password)
    {
        string apiUrl = "https://localhost:7055/api/User/checkCredentials";

        var requestBody = new
        {
            tc = username,
            userPassword = password
        };

        return RedirectToAction("Index", "AnaSayfa");

        //try
        //{
        //    using (var client = new HttpClient())
        //    {
        //        // JSON içeriği oluştur
        //        var jsonContent = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

        //        // POST isteği gönder
        //        var response = await client.PostAsync(apiUrl, jsonContent);

        //        // StatusCode'a göre yanıtı işle
        //        if (response.IsSuccessStatusCode)
        //        {
        //            // Başarılı yanıt durumunda içerik okunur
        //            var responseContent = await response.Content.ReadAsStringAsync();
        //            var validationResponse = JsonConvert.DeserializeObject<UserResponse>(responseContent);

        //            if (validationResponse != null && validationResponse.User != null)
        //            {
        //                // Kullanıcı doğrulandı, rolü al
        //                var userRole = validationResponse.User.Rol;

        //                // Rolü oturumda sakla
        //                HttpContext.Session.SetString("UserRole", userRole);

        //                // Giriş başarılı, AnaSayfa/Index'e yönlendir
        //                return RedirectToAction("Index", "AnaSayfa");
        //            }
        //            else
        //            {
        //                ViewBag.ErrorMessage = validationResponse?.Message ?? "Kullanıcı doğrulama başarısız.";
        //                return View("Giris");
        //            }
        //        }
        //        else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
        //        {
        //            // Yetkisiz erişim
        //            ViewBag.ErrorMessage = "Kullanıcı adı veya şifre hatalı.";
        //            return View("Giris");
        //        }
        //        else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
        //        {
        //            // Hatalı istek
        //            ViewBag.ErrorMessage = "Hatalı istek gönderildi. Lütfen bilgileri kontrol edin.";
        //            return View("Giris");
        //        }
        //        else
        //        {
        //            // Genel hata durumu
        //            ViewBag.ErrorMessage = $"Sunucu hatası: {response.StatusCode}";
        //            return View("Giris");
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    // Hata durumunda kullanıcıyı bilgilendir
        //    ViewBag.ErrorMessage = $"Beklenmeyen bir hata oluştu: {ex.Message}";
        //    return View("Giris");
        //}
    }

}
