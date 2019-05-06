using Abp.Authorization;
using MYABP.Authorization.Roles;
using MYABP.Authorization.Users;

namespace MYABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
