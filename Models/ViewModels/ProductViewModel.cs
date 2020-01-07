﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shoes.Models.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public int? IdType { get; set; }
        public int? IdColor { get; set; }
        public int? IdBrand { get; set; }
        public int? IdProvider { get; set; }
        public int IdCatalog { get; set; }
        public string Title { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public string Observations { get; set; }
        public decimal? PriceDistributor { get; set; }
        public decimal PriceClient { get; set; }
        public decimal PriceMember { get; set; }
        [Required]
        [Display(Name ="IsEnabled")]
        public bool IsEnabled { get; set; }
        public string Keywords { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateUpdate { get; set; }
    }
}