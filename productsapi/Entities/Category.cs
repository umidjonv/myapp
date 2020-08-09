using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using productsapi.Data;
using productsapi.DTO;
using productsapi.Helpers;
using productsapi.Models;
using productsapi.Repositories;


namespace productsapi.Models
{
    [Table("category")]
    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(100)]
        public string name { get; set; }

        public IEnumerable<Category> children;

        public Category parent;

        public bool status { get; set; }

        //public DateTime createdAt { get; set; }
        //public DateTime updatedAt { get; set; }

    }
}
