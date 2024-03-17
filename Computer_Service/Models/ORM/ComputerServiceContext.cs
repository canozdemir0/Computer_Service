using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Service.Models.ORM
{
    public class ComputerServiceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=101-5\\SQLEXPRESS;Database=UniversityDb;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<ServiceRecords> ServiceRecords { get; set; }
        public DbSet<ServiceStatus> ServiceStatuses { get; set; }
        public DbSet<SpareParts> SpareParts { get; set; }
        public DbSet<Staff> Staffs { get; set;}

    }
}
