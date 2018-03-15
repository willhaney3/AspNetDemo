using System.Threading.Tasks;
using Abp.Application.Services;
using AspNetDemo.Authorization.Accounts.Dto;

namespace AspNetDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
