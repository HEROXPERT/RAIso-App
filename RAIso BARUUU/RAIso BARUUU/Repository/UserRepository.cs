using RAIso_BARUUU.Factory;
using RAIso_BARUUU.Model;
using System.Collections.Generic;
using System;
using System.Linq;

namespace RAIso_BARUUU.Repository
{
    public static class UserRepository
    {
        public static Database1Entities2 db = DatabaseSingleton.getInstance();

        public static List<MsUser> getUser()
        {
            return (from x in db.MsUsers select x).ToList();
        }

        public static MsUser getUserbyId(int id)
        {
            return (from x in db.MsUsers where x.UserID == id select x).FirstOrDefault();
        }

        public static void Create(int id, string username, string gender, DateTime dob, string phone, string address, string password, string role)
        {
            MsUser user = UserFactory.Create(id, username, gender, dob, phone, address, password, role);
            db.MsUsers.Add(user);
            db.SaveChanges();
        }

        public static int generateId()
        {
            int latestId = (from x in db.MsUsers select x.UserID).ToList().LastOrDefault();
            if (latestId == 0)
            {
                return 1;
            }
            latestId++;
            return latestId;
        }

        public static void Update(int id, string username, string gender, DateTime dob, string phone, string address, string password)
        {
            MsUser user = getUserbyId(id);
            if (user != null)
            {
                user.UserName = username;
                user.UserGender = gender;
                user.UserDOB = dob;
                user.UserPhone = phone;
                user.UserAddress = address;
                user.UserPassword = password;

                db.SaveChanges();
            }
        }

        public static MsUser checkUsername(string username)
        {
            return (from x in db.MsUsers where x.UserName == username select x).FirstOrDefault();
        }

        public static MsUser getUserbyUsernameandPassword(string username, string password)
        {
            return (from x in db.MsUsers where x.UserName == username && x.UserPassword == password select x).FirstOrDefault();
        }
    }
}