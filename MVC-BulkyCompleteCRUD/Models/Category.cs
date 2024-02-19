﻿using System.ComponentModel.DataAnnotations;

namespace MVC_BulkyCompleteCRUD.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
