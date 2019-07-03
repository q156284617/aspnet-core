using System.Threading.Tasks;
using WebProject.Configuration.Dto;

namespace WebProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
