using System.Collections.Generic;
using ZdyCore.PhoneBook.Roles.Dto;

namespace ZdyCore.PhoneBook.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}