using Abp.Authorization;
using WebProject.Authorization.Roles;
using WebProject.Authorization.Users;

namespace WebProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
