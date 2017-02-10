using System.Reflection;
using Abp.Modules;

namespace IPSP
{
    [DependsOn(typeof(IPSPCoreModule))]
    public class IPSPApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            DtoMapping.Map();
        }
    }
}
