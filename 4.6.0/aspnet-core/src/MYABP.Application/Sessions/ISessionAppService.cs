using System.Threading.Tasks;
using Abp.Application.Services;
using MYABP.Sessions.Dto;

namespace MYABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
