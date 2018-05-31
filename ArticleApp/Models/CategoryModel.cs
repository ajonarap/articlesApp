﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClientArticleApp.Models
{
    [Table("Categories")]
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }

    }
}