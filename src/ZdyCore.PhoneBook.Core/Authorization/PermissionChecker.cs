using Abp.Authorization;
using ZdyCore.PhoneBook.Authorization.Roles;
using ZdyCore.PhoneBook.Authorization.Users;

namespace ZdyCore.PhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
