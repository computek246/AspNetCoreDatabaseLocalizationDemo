using Microsoft.AspNetCore.Identity;

namespace AspNetCoreDatabaseLocalizationDemo.DataBase.Entities
{
    public class ApplicationRoleClaim : IdentityRoleClaim<int>
    {
        public virtual ApplicationRole Role { get; set; }
    }
}