using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class ProductGroup
    {
        public ProductGroup()
        {
            Categories = new HashSet<ProductCategory>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string GroupCode { set; get; }
        public string GroupName { set; get; }
        public string Alias { set; get; }
        public string Caption { set; get; }
        public string Description { set; get; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ProductCategory> Categories { set; get; }
    }
}
