using Abp.EntityFramework;
using IPSP.Case;
using IPSP.Case.Patent;
using IPSP.Contact.Client;
using System.Data.Entity;

namespace IPSP.EntityFramework
{
    public class IPSPDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public virtual IDbSet<BaseCase> BaseCases { get; set; }

        public virtual IDbSet<Client> Clients { get; set; }

        //public virtual IDbSet<Patent> Patents { get; set; }

        public IPSPDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in IPSPDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of IPSPDbContext since ABP automatically handles it.
         */
        public IPSPDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
