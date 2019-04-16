using Abp.AutoMapper;
using ZdyCore.PhoneBook.Authentication.External;

namespace ZdyCore.PhoneBook.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
