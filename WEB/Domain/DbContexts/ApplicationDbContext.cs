using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace Domain.DbContexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole,string>
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
        public virtual DbSet<ProductColor> ProductColors { set; get; }
        public virtual DbSet<Country> Countries { set; get; }
        public virtual DbSet<ProvinceCity> ProvinceCities { set; get; }
        public virtual DbSet<Ward> Wards { set; get; }
        public virtual DbSet<Manufacturer> Manufacturers { set; get; }
        public virtual DbSet<Permission> Permissions { set; get; }
        public virtual DbSet<ProductImages> ProductImages { set; get; }
        public virtual DbSet<Product> Products { set; get; }
        public virtual DbSet<Comment> Comments { set; get; }
        public virtual DbSet<ProductCategory> ProductCategories { set; get; }
        public virtual DbSet<ProductGroup> ProductGroups { set; get; }
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
