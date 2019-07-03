using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using WebProject.Configuration.Dto;

namespace WebProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WebProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
