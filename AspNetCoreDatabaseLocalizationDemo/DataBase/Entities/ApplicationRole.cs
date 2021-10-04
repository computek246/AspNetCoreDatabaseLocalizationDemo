using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreDatabaseLocalizationDemo.DataBase.Entities
{
    public class ApplicationRole : IdentityRole<int>
    {
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<ApplicationRoleClaim> RoleClaims { get; set; }
    }
}