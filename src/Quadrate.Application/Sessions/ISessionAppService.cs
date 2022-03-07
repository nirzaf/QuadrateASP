using System.Threading.Tasks;
using Abp.Application.Services;
using Quadrate.Sessions.Dto;

namespace Quadrate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
