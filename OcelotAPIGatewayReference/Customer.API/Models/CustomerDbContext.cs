using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerService.Models;

namespace CustomerService.Models
{
    public class CustomerDbContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"data source=bluesapphire\sqlexpress;Initial Catalog=CustomerMicroservice;Integrated Security=True;");

        }
    }
}
