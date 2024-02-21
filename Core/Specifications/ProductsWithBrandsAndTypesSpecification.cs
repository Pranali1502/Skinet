using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entity;

namespace Core.Specifications
{
    public class ProductsWithBrandsAndTypesSpecification: BaseSpecification<Product>
    {
        public ProductsWithBrandsAndTypesSpecification()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
        public ProductsWithBrandsAndTypesSpecification(int id): base(x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}