using System.Collections.Generic;
using ZdyCore.PhoneBook.Roles.Dto;
using ZdyCore.PhoneBook.Users.Dto;

namespace ZdyCore.PhoneBook.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
