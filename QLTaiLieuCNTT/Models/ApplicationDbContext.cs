using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace QLTaiLieuCNTT.Models
{


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<TaiLieu> TaiLieu { get; set; }
        public DbSet<LoaiTaiLieu> LoaiTaiLieu { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}