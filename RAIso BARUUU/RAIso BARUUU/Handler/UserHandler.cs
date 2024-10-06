using RAIso_BARUUU.Model;
using RAIso_BARUUU.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;

namespace RAIso_BARUUU.Handler
{
    public class UserHandler
    {
        public static List<MsUser> getUser()
        {
            return UserRepository.getUser();
        }

        public static void Create(int id, String username, String gender, DateTime dob, String phone, String address, String password, String role)
        {
            UserRepository.Create(id, username, gender, dob, phone, address, password, role);
        }

        public static void Update(int id, String username, String gender, DateTime dob, String phone, String address, String password)
        {
            UserRepository.Update(id, username, gender, dob, phone,address, password);
        }

        public static MsUser checkUsername(String username)
        {
            return UserRepository.checkUsername(username);
        }

        public static MsUser getUserbyId(int id)
        {
            return UserRepository.getUserbyId(id);
        }

        public static int generateId()
        {
            return UserRepository.generateId();
        }

        public static MsUser getbyUserandPass(String username, String password)
        {
            return UserRepository.getUserbyUsernameandPassword(username, password);
        }
        
    }
}