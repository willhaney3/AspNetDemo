using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AspNetDemo.EntityFramework.Repositories
{
    public abstract class AspNetDemoRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AspNetDemoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AspNetDemoRepositoryBase(IDbContextProvider<AspNetDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AspNetDemoRepositoryBase<TEntity> : AspNetDemoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AspNetDemoRepositoryBase(IDbContextProvider<AspNetDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
