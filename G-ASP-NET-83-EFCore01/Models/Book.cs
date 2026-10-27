using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace G_ASP_NET_83_EFCore01.Models
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int NoOfPages { get; set; }
        public DateTime PublishedYear { get; set; }
        public string InStock { get; set; } 
    }
}
