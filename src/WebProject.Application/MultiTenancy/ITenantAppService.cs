using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WebProject.MultiTenancy.Dto;

namespace WebProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

