using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Domain.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base()
        {
            UserInGroups = new HashSet<UserInGroup>();
            Permissions = new HashSet<Permission>();
        }
        public virtual string Address { set; get; }
        public virtual bool Gender { set; get; }
        public virtual int MobilePhone { set; get; }
        public virtual DateTime Birthday { set; get; }
        public virtual int? OfficeNumber { get; set; }
        public virtual string FamilyName { get; set; }
        public virtual string GivenName { get; set; }
        public virtual string MiddleName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Picture { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<UserInGroup> UserInGroups { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
