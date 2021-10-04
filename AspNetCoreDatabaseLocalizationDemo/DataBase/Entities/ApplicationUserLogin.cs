using Microsoft.AspNetCore.Identity;

namespace AspNetCoreDatabaseLocalizationDemo.DataBase.Entities
{
    public class ApplicationUserLogin : IdentityUserLogin<int>
    {
        public virtual ApplicationUser User { get; set; }
    }
}