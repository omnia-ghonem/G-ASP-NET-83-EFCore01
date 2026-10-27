using G_ASP_NET_83_EFCore01.Contexts;
using Microsoft.EntityFrameworkCore;
using G_ASP_NET_83_EFCore01.Models;
namespace G_ASP_NET_83_EFCore01
{
    internal class Program
    {
 
        
        static void Main(string[] args)
        {

            //var builder = new DbContextOptionsBuilder<BookAppDbContext>();
            //builder.UseSqlServer("Server = .; Database = EF01G04; Trusted_Connection = True; TrustServerCertificate=True");

            ReadMoreBooksDB context = new ReadMoreBooksDB();
            Console.WriteLine(context.Database.CanConnect() ? "Connection successful": "Connection failed");
        }
    }
}
