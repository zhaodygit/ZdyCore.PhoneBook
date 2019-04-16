using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ZdyCore.PhoneBook.MultiTenancy.Dto;

namespace ZdyCore.PhoneBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

