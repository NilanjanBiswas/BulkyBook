﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BulkyBook.Models
{
    public class Category
    {
        [Key]
        public int id  { get; set; }

        [Display(Name="Category Name")]
        [Required]
        [MaxLength(50)]

        public string name  { get; set; }
    }
}
