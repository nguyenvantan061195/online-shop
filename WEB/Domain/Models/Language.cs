using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    [Table("Language")]
    public class Language
    {
        public Language()
        {
            LanguageTexts = new HashSet<LanguageText>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(maximumLength: 10)]
        public string Culture { get; set; }

        [StringLength(maximumLength: 256)]
        public string DisplayName { get; set; }

        [StringLength(maximumLength: 128)]
        public string Icon { get; set; }

        public int Ordering { get; set; }

        public bool IsEnabled { get; set; }
        public bool? IsDefault { get; set; }

        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LanguageText> LanguageTexts { get; set; }
    }
}
