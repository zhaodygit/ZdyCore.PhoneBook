using Abp.AutoMapper;
using ZdyCore.PhoneBook.Sessions.Dto;

namespace ZdyCore.PhoneBook.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
