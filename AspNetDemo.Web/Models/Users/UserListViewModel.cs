using System.Collections.Generic;
using AspNetDemo.Roles.Dto;
using AspNetDemo.Users.Dto;

namespace AspNetDemo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}