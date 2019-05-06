using System.Threading.Tasks;
using Abp.Application.Services;
using MYABP.Authorization.Accounts.Dto;

namespace MYABP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
