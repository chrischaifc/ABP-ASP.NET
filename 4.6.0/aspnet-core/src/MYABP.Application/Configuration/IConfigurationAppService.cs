using System.Threading.Tasks;
using MYABP.Configuration.Dto;

namespace MYABP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
