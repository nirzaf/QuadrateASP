using Abp.Authorization;
using Quadrate.Authorization.Roles;
using Quadrate.Authorization.Users;

namespace Quadrate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
