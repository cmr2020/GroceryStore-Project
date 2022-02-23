using _0_Framework.Domain;
using AccountManagement.Domain.Contacts;
using AccountManagement.Domain.RoleAgg;
using System.Collections.Generic;

namespace AccountManagement.Domain.AccountAgg
{
    public class Account : EntityBase
    {
        public string Fullname { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Mobile { get; private set; }
        public string Address { get; private set; }
        public string Code { get; private set; }
        public long RoleId { get; private set; }
        public Role Role { get; private set; }
        public string ProfilePhoto { get; private set; }
       

        public Account(string fullname, string username, string password, string mobile,string address,
        string code, long roleId, string profilePhoto)
        {
            Fullname = fullname;
            Username = username;
            Password = password;
            Mobile = mobile;
            Address = address;
            Code = code;
            RoleId = roleId;

            if (roleId == 0)
                RoleId = 2;

            ProfilePhoto = profilePhoto;
        }

        public void Edit(string fullname, string username, string mobile,string address,
        string code, long roleId, string profilePhoto)
        {
            Fullname = fullname;
            Username = username;
            Mobile = mobile;
            Address = address;
            Code = code;
            RoleId = roleId;

            if (!string.IsNullOrWhiteSpace(profilePhoto))
                ProfilePhoto = profilePhoto;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }

    }
}
