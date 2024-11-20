using Microsoft.EntityFrameworkCore;
using yurtyonetimibackend.dataccess;
using yurtyonetimibackend.models;

namespace yurtyonetimibackend.UserRepository
{
    public class UserDataAccess
    {
        public async Task<User?> GetByCredentialsAsync(string username, string password)
        {
            using (var ctx = new yurtyonetimicontext())
            {
                // Kullanıcı adı ve şifreyi kontrol et
                return await ctx.Set<User>()
                    .FirstOrDefaultAsync(u => u.tc == username && u.sifre == password);
            }
        }
    }
}