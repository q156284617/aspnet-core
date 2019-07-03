using System.Threading.Tasks;
using Abp.Application.Services;
using WebProject.Sessions.Dto;

namespace WebProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
