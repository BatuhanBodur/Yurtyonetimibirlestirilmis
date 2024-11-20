using Microsoft.EntityFrameworkCore;
using yurtyonetimibackend.models;

namespace yurtyonetimibackend.dataccess
{
    public class yurtyonetimicontext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=CANAVAR;Initial Catalog=yurtyonetimsistemi;Integrated Security=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }
    }
}
