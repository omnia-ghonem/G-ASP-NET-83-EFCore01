using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using G_ASP_NET_83_EFCore01.Models;

namespace G_ASP_NET_83_EFCore01.Contexts
{
 
    public class ReadMoreBooksDB : DbContext
    {


        public ReadMoreBooksDB() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connection string to connect to the database
            optionsBuilder.UseSqlServer(@"Server=.;Database=BookAppDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }



    }
}
