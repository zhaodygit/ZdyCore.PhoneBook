﻿using Abp.AutoMapper;
using ZdyCore.PhoneBook.Roles.Dto;
using ZdyCore.PhoneBook.Web.Models.Common;

namespace ZdyCore.PhoneBook.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public EditRoleModalViewModel(GetRoleForEditOutput output)
        {
            output.MapTo(this);
        }

        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
