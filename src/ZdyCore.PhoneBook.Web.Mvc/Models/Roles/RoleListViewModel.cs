using System.Collections.Generic;
using ZdyCore.PhoneBook.Roles.Dto;

namespace ZdyCore.PhoneBook.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
