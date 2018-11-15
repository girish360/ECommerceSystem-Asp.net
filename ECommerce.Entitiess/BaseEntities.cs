using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entitiess
{
    public class BaseEntities
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
    }
}
