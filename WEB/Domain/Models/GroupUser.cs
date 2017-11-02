using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    [Table("GroupUser")]
    public class GroupUser
    {
        public GroupUser()
        {
            UserInGroups = new HashSet<UserInGroup>();
           Permissions = new HashSet<Permission>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime? CreatedDate { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual ICollection<UserInGroup> UserInGroups { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
