using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    [Table("UserInGroup")]
    public class UserInGroup
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int GroupUserId { get; set; }
        public virtual GroupUser GroupUser { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string RoleId { get; set; }
        public virtual IdentityRole Role { get; set; }
    }

    public class UserInGroupModel
    {
        public int GroupUserId { get; set; }
        public List<UserInGroup> UserInGroups { get; set; }
    }
}
