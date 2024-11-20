using Microsoft.AspNetCore.Mvc;
using yurtyonetimibackend.UserRepository;
using yurtyonetimibackend.models;

namespace yurtyonetimibackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserDataAccess _userDataAccess;

        public UserController()
        {
            _userDataAccess = new UserDataAccess();
        }

        // POST: api/User/checkCredentials
        [HttpPost("checkCredentials")]
        public async Task<IActionResult> CheckCredentials([FromBody] UserPostDto loginDto)
        {
            if (loginDto == null || string.IsNullOrEmpty(loginDto.tc) || string.IsNullOrEmpty(loginDto.UserPassword))
            {
                return BadRequest(new { message = "Kullanıcı adı ve şifre boş olamaz." });
            }

            try
            {
                var user = await _userDataAccess.GetByCredentialsAsync(loginDto.tc, loginDto.UserPassword);

                if (user == null)
                {
                    return Unauthorized(new { message = "Kullanıcı adı veya şifre hatalı." });
                }

                return Ok(new
                {
                    message = "Kullanıcı doğrulandı.",
                    user = new
                    {
                        user.user_id,
                        user.ad,
                        user.soyad,
                        user.rol,
                    }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error.", error = ex.Message });
            }
        }
    }


}