﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNET5.Controllers.Model
{
    [Table("books")]
    public class Books
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("title")]
        public string Title { get; set; }
    }
}
