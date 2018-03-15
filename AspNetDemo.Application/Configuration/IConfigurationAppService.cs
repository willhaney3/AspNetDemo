using System.Threading.Tasks;
using Abp.Application.Services;
using AspNetDemo.Configuration.Dto;

namespace AspNetDemo.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}