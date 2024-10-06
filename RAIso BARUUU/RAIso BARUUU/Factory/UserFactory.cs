using RAIso_BARUUU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAIso_BARUUU.Factory
{
    public class UserFactory
    {
        public static MsUser Create(int id, String username, String gender, DateTime dob, String phone, String address, String password, String role)
        {
            MsUser user = new MsUser();
            user.UserID = id;
            user.UserName = username;
            user.UserGender = gender;
            user.UserDOB = dob;
            user.UserPhone = phone;
            user.UserAddress = address;
            user.UserPassword = password;
            user.UserRole = role;

            return user;
        }
    }
}