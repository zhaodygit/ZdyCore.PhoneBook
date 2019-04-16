using System.Threading.Tasks;
using Abp.Application.Services;
using ZdyCore.PhoneBook.Authorization.Accounts.Dto;

namespace ZdyCore.PhoneBook.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
