﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Web.ViewModels
{
    public class NewCategoryViewModel
    {
        [Required]
        [MinLength(5), MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public int CategoryID { get; set; }
    }

    public class EditCategoryViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public string ImageURL { get; set; }

        public bool isFeatured { get; set; }
    }
}