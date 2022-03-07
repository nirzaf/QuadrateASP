using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Quadrate.Configuration.Dto;

namespace Quadrate.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : QuadrateAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
