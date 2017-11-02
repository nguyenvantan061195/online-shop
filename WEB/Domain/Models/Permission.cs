using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    [Table("Permission")]
    public class Permission
    {
        [Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? GroupUserId { get; set; }
        public virtual GroupUser GroupUser { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }
        public virtual AspNetUser User { get; set; }

        [StringLength(50)]
        public string RoleId { get; set; }
        public virtual AspNetRole Role { get; set; }
    }

    public class PermissionModel
    {
        public int? ApplicationId { get; set; }
        public int? FunctionId { get; set; }
        public int? GroupUserId { get; set; }
        public List<UserInGroup> UserInGroups { get; set; }
    }
}
