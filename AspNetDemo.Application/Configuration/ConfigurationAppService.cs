using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AspNetDemo.Configuration.Dto;

namespace AspNetDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AspNetDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
