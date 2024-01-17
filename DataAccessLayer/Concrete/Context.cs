using Microsoft.EntityFrameworkCore;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    //DbContext yerine IdentityDbContext den miras almaya gittik
    //çünkü bu sınıf bize gerekli olan bazı tabloları igration da otomatik olarak tanımlamamızı sağlıyor
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-9D1JVJE\\SQLEXPRESS; database=DbNewOopCore1; integrated security=true; encrypt=false");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}
