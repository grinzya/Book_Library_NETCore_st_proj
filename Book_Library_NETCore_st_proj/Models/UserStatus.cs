using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Library_NETCore_st_proj.Models
{
    public enum UserStatus
    {
        User = 1,

        Admin = 2
    }

    //wrapper for role (const string)
    public static class Roles
    {
        public const string User = "User";
        public const string Admin = "Admin";

        public static Dictionary<UserStatus, string> RolesDictionary = new Dictionary<UserStatus, string>()
        {
            { UserStatus.User, User },
            { UserStatus.Admin, Admin }
        };
    }
}
