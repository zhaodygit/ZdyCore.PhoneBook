﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ZdyCore.PhoneBook.Configuration.Dto;

namespace ZdyCore.PhoneBook.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PhoneBookAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
