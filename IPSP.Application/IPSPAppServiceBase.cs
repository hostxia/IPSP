using Abp.Application.Services;

namespace IPSP
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class IPSPAppServiceBase : ApplicationService
    {
        protected IPSPAppServiceBase()
        {
            LocalizationSourceName = IPSPConsts.LocalizationSourceName;
        }
    }
}