using Abp.Web.Mvc.Views;

namespace AspNetDemo.Web.Views
{
    public abstract class AspNetDemoWebViewPageBase : AspNetDemoWebViewPageBase<dynamic>
    {

    }

    public abstract class AspNetDemoWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AspNetDemoWebViewPageBase()
        {
            LocalizationSourceName = AspNetDemoConsts.LocalizationSourceName;
        }
    }
}