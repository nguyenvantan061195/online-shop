using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    [Table("ActionLog")]
    public class ActionLog
    {
        public ActionLog()
        {
        }

        public ActionLog(IHttpContextAccessor accessor)
        {
            string browser = accessor.HttpContext.Request.Headers["User-Agent"];
            if (!string.IsNullOrEmpty(browser) && (browser.Length > 255))
            {
                browser = browser.Substring(0, 255);
            }

            CreatedDate = DateTime.Now;
            CreatedBy = accessor.HttpContext.User?.Identity?.Name;
            Browser = browser;
            Host = accessor.HttpContext.Connection?.RemoteIpAddress?.ToString();
            Path = accessor.HttpContext.Request.Path;
            IpAddress = accessor.HttpContext.Connection?.LocalIpAddress?.ToString();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string LogLevel { get; set; }

        [StringLength(2000)]
        public string Message { get; set; }

        [StringLength(255)]
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        [StringLength(300)]
        public string Browser { get; set; }

        [StringLength(100)]
        public string Host { get; set; }

        [StringLength(300)]
        public string Path { get; set; }

        [StringLength(20)]
        public string IpAddress { get; set; }

        public string Data { get; set; }
    }
}
