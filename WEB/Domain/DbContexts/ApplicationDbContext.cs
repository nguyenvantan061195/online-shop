using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Domain.DbContexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, AspNetRole,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // initial DbSet
        public virtual DbSet<Language> Languages { set; get; }
        public virtual DbSet<LanguageText> LanguageTexts { set; get; }
        public virtual DbSet<ActionLog> ActionLogs { set; get; }
        public virtual DbSet<GroupUser> GroupUsers { set; get; }
        public virtual DbSet<UserInGroup> UserInGroups { set; get; }
        public virtual DbSet<Permission> Permissions { set; get; }
        public virtual DbSet<AspNetRole> AspNetRoles { set; get; }
        public virtual DbSet<AspNetUser> AspNetUser { set; get; }

        // Config Table
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
