using System.Threading.Tasks;
using ZdyCore.PhoneBook.Configuration.Dto;

namespace ZdyCore.PhoneBook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
