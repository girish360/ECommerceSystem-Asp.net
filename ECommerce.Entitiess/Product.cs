using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entitiess
{
    public class Product : BaseEntities
    {
        public decimal Price { get; set; }
        public Category Category { get; set; }
 
    }
}
