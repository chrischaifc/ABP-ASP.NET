using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MYABP.Configuration.Dto;

namespace MYABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MYABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
