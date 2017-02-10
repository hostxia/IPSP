using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace IPSP
{
    [DependsOn(typeof(AbpWebApiModule), typeof(IPSPApplicationModule))]
    public class IPSPWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(IPSPApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
