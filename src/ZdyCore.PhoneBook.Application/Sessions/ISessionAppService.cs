using System.Threading.Tasks;
using Abp.Application.Services;
using ZdyCore.PhoneBook.Sessions.Dto;

namespace ZdyCore.PhoneBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
