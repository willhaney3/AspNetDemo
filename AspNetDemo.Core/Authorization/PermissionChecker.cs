using Abp.Authorization;
using AspNetDemo.Authorization.Roles;
using AspNetDemo.Authorization.Users;

namespace AspNetDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
