using System.Reflection;
using Abp.Modules;

namespace IPSP
{
    public class IPSPCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            IPSPCache.InitialCache();
        }
    }
}
