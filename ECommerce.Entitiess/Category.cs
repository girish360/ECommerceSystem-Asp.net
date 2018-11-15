using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entitiess
{
    public class Category : BaseEntities
    {
        public List<Product> Products { get; set; }
    }
}
