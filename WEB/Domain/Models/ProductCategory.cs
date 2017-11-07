using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string CategoryCode { set; get; }
        public string CategoryName { set; get; }
        public string Caption { set; get; }
        public string Description { set; get; }
        public DateTime? CreatedDate { get; set; }
        public int ParentId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Product> Products { set; get; }
    }
}
