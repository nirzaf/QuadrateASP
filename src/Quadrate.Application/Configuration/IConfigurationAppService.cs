using System.Threading.Tasks;
using Quadrate.Configuration.Dto;

namespace Quadrate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
