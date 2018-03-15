using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AspNetDemo.MultiTenancy.Dto;

namespace AspNetDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
