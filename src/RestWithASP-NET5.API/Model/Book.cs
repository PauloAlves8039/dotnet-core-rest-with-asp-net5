﻿using RestWithASP_NET5.API.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASP_NET5.API.Model
{
    [Table("person")]
    public class Book : BaseEntity
    {
        [Column("title")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
    }
}
