using Abp.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IPSP.Wcf
{
    [DependsOn(typeof(IPSPApplicationModule), typeof(IPSPDataModule))]
    public class IPSPServerModule : AbpModule
    {
        public override void Initialize()
        {
            base.IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
