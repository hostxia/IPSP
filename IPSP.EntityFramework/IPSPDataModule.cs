using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using IPSP.EntityFramework;

namespace IPSP
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(IPSPCoreModule))]
    public class IPSPDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<IPSPDbContext>(null);
        }
    }
}
