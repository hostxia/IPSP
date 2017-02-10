using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace IPSP.EntityFramework.Repositories
{
    public abstract class IPSPRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<IPSPDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected IPSPRepositoryBase(IDbContextProvider<IPSPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class IPSPRepositoryBase<TEntity> : IPSPRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected IPSPRepositoryBase(IDbContextProvider<IPSPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
