using Core.Entity;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SpecificationEvaluator<TEntity> where TEntity: BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity>specs)
        {
            var query= inputQuery;
            if(specs.Criteria != null)
            {
                query = query.Where(specs.Criteria);
            }

            if(specs.OrderBy != null)
            {
                query = query.OrderBy(specs.OrderBy);
            }

            if(specs.OrderByDescending != null)
            {
                query = query.OrderByDescending(specs.OrderByDescending);
            }
            if(specs.isPagingEnabled)
            {
                query= query.Skip(specs.Skip).Take(specs.Take);
            }
            
            query = specs.Includes.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }
    }
}