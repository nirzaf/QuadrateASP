using System.Threading.Tasks;
using Abp.Application.Services;
using Quadrate.Authorization.Accounts.Dto;

namespace Quadrate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
