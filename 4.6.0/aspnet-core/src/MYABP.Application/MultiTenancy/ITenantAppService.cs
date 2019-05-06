using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MYABP.MultiTenancy.Dto;

namespace MYABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

