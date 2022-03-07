using Abp.Application.Services;
using Quadrate.MultiTenancy.Dto;

namespace Quadrate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

