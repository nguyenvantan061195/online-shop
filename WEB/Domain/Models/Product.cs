using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class Product
    {
        public Product()
        {
            Images = new HashSet<ProductImages>();
            Comments = new HashSet<Comment>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string ProductCode { set; get; }
        public string ProductName { set; get; }
        public string Alias { set; get; }
        public string Caption { set; get; }
        public decimal Price { set; get; }
        public int Quantity { set; get; }
        public float Promotion { set; get; }
        public int Favorite { set; get; }
        public int Currency { set; get; }
        public string Description { set; get; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Comment> Comments { set; get; }
        public ICollection<ProductImages> Images { set; get; }
    }
}
