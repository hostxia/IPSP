using Abp.Web.Mvc.Controllers;

namespace IPSP.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class IPSPControllerBase : AbpController
    {
        protected IPSPControllerBase()
        {
            LocalizationSourceName = IPSPConsts.LocalizationSourceName;
        }
    }
}