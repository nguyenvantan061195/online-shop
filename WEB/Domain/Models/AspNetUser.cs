using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class AspNetUser : IdentityUser
    {
        public AspNetUser() : base()
        {
            BEUserInGroups = new HashSet<UserInGroup>();
            BEPermissions = new HashSet<Permission>();
        }
        public virtual int? OfficeNumber { get; set; }
        public virtual string FamilyName { get; set; }
        public virtual string GivenName { get; set; }
        public virtual string MiddleName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Picture { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<UserInGroup> BEUserInGroups { get; set; }
        public virtual ICollection<Permission> BEPermissions { get; set; }
    }
    }
