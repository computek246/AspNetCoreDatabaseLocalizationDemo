using Microsoft.AspNetCore.Identity;

namespace AspNetCoreDatabaseLocalizationDemo.DataBase.Entities
{
    public class ApplicationUserRole : IdentityUserRole<int>
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}