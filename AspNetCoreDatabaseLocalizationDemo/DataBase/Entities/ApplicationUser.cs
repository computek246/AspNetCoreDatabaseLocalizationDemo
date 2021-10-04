using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreDatabaseLocalizationDemo.DataBase.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string UserPassword { get; set; }
        public string Culture { get; set; }

        //--------------------------------------
        public bool IsActive { get; set; }
        public int? CreatorId { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? ModifierId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        //--------------------------------------


        public virtual ICollection<ApplicationUserClaim> Claims { get; set; }
        public virtual ICollection<ApplicationUserLogin> Logins { get; set; }
        public virtual ICollection<ApplicationUserToken> Tokens { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
