using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebEntityFramworkApp1.Models;

namespace WebEntityFramworkApp1.DatabaseContext
{
    public class ConnectionString : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

    }
}