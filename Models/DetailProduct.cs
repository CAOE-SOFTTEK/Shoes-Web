//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shoes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailProduct
    {
        public int IdDetail { get; set; }
        public int IdProduct { get; set; }
        public int IdTypeDetail { get; set; }
        public string Description { get; set; }
        public string DateUpdate { get; set; }
    
        public virtual CatTypeDetails CatTypeDetails { get; set; }
        public virtual Products Products { get; set; }
    }
}
