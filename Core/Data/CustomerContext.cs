﻿using Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Core.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
