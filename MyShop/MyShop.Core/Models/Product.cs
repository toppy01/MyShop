using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    //Public as will need to be accessed by other files
    public class Product
    {
        
        public string Id { get; set; }

        [StringLength(20)]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }

        //Validation
        [Range(0,1000)]
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }

        //New ID is created for each product
        public Product()
        {
            this.Id = Guid.NewGuid().ToString();

        }
    }
}
