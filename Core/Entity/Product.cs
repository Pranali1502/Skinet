using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }    
        public string Description { get; set; }
        public int Price { get; set; }  
        public string PictureUrl { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public ProductBrand MyProperty { get; set; }
        public int ProductBrandId { get; set; }
    }

}