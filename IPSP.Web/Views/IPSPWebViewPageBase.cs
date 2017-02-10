using Abp.Web.Mvc.Views;

namespace IPSP.Web.Views
{
    public abstract class IPSPWebViewPageBase : IPSPWebViewPageBase<dynamic>
    {

    }

    public abstract class IPSPWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected IPSPWebViewPageBase()
        {
            LocalizationSourceName = IPSPConsts.LocalizationSourceName;
        }
    }
}