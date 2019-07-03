using System.Threading.Tasks;
using Abp.Application.Services;
using WebProject.Authorization.Accounts.Dto;

namespace WebProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
