using RAIso_BARUUU.Handler;
using RAIso_BARUUU.Model;
using System;
using System.Text.RegularExpressions;

namespace RAIso_BARUUU.Controller
{
    public class UserController
    {
        public static string Register(string username, string gender, DateTime dob, string phone, string address, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(gender) || dob == null || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(password))
            {
                return "All fields must be filled!";
            }
            if (username.Length < 5 || username.Length > 50)
            {
                return "Username needs to be between 5 and 50 characters!";
            }
            if (UserHandler.checkUsername(username) != null)
            {
                return "Username has been picked!";
            }
            if (DateTime.Now < dob.AddYears(1))
            {
                return "Age must be at least 1 year old!";
            }

            if (!IsAlphanumeric(password))
            {
                return "Password must be alphanumeric!";
            }
            int id = UserHandler.generateId();
            UserHandler.Create(id, username, gender, dob, phone, address, password, "Customer");
            return null;
        }

        public static bool IsAlphanumeric(string input)
        {
            string pattern = "^[a-zA-Z0-9]+$";
            return Regex.IsMatch(input, pattern);
        }

        public static string Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "All fields must be filled";
            }
            MsUser user = UserHandler.checkUsername(username);
            if (user == null)
            {
                return "Wrong username";
            }
            if (user.UserPassword != password)
            {
                return "Wrong Password!";
            }
            if (username == "Admin" && password == "admin")
            {
                return "Admin";
            }
            return "success";
        }

        public static string Update(int id, string username, string gender, DateTime dob, string phone, string address, string password, string usernameBefore)
        {
            MsUser user = UserHandler.getUserbyId(id);
            if (user == null)
            {
                return "User not found!";
            }
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(gender) || dob == null || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(password))
            {
                return "All fields must be filled!";
            }
            if (username.Length < 5 || username.Length > 50)
            {
                return "Username needs to be between 5 and 50 characters!";
            }

            if (DateTime.Now < dob.AddYears(1))
            {
                return "Age must be at least 1 year old!";
            }
            if (!IsAlphanumeric(password))
            {
                return "Password must be alphanumeric!";
            }
            if (username.Equals(usernameBefore))
            {
                UserHandler.Update(id, username, gender, dob, phone, address, password);
                return null;
            }
            if (UserHandler.checkUsername(username) != null)
            {
                return "Username has been picked!";
            }
            UserHandler.Update(id, username, gender, dob, phone, address, password);
            return null;
        }

        public static string UpdateAdmin(int id, string username, string gender, DateTime dob, string phone, string address, string password, string usernameBefore)
        {
            MsUser user = UserHandler.getUserbyId(id);
            if (user == null)
            {
                return "User not found!";
            }
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(gender) || dob == null || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(password))
            {
                return "All fields must be filled!";
            }
            if (username.Length < 5 || username.Length > 50)
            {
                return "Username needs to be between 5 and 50 characters!";
            }

            if (DateTime.Now < dob.AddYears(1))
            {
                return "Age must be at least 1 year old!";
            }
            if (!IsAlphanumeric(password))
            {
                return "Password must be alphanumeric!";
            }
            if (username.Equals(usernameBefore) || UserHandler.checkUsername(username) == null)
            {
                UserHandler.Update(id, username, gender, dob, phone, address, password);
                return null;
            }
            return "Username has been picked!";
        }

        public static MsUser getUserbyusername(string username)
        {
            return UserHandler.checkUsername(username);
        }

        public static MsUser getUserbyId(int id)
        {
            return UserHandler.getUserbyId(id);
        }
    }
}