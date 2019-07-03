using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WebProject.Roles.Dto;
using WebProject.Users.Dto;

namespace WebProject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
