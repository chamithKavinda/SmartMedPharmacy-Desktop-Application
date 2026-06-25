using System;
using System.Collections.Generic;
using SmartMedPharmacy.Data;
using SmartMedPharmacy.Models;
using SmartMedPharmacy.Utill;

namespace SmartMedPharmacy.Controller
{
    public class UserController
    {
        private readonly UserRepository _userRepository;

        public UserController()
        {
            _userRepository = new UserRepository();
        }

        // ---------------- Save User ----------------
        public string Register(
            string mobileNumber,
            string email,
            string address,
            string password,
            string role)
        {
            if (string.IsNullOrWhiteSpace(mobileNumber))
                return "Mobile Number is required.";

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                return "Invalid Email.";

            if (string.IsNullOrWhiteSpace(address))
                return "Address is required.";

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                return "Password must be at least 6 characters.";

            if (_userRepository.MobileNumberExists(mobileNumber))
                return "Mobile Number already exists.";

            if (_userRepository.EmailExists(email))
                return "Email already exists.";

            User user = new User
            {
                MobileNumber = mobileNumber,
                Email = email,
                Address = address,
                Password = PasswordHasher.HashPassword(password),
                Role = role
            };

            bool success = _userRepository.RegisterUser(user);

            return success ? null : "Registration failed.";
        }

        // ---------------- get All Users ----------------
        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        // ---------------- Search User ----------------
        public User GetUserByMobile(string mobileNumber)
        {
            return _userRepository.GetUserByMobile(mobileNumber);
        }

        // ---------------- Update User ----------------
        public string UpdateUser(
            string mobileNumber,
            string email,
            string address,
            string password,
            string role)
        {
            User existingUser = _userRepository.GetUserByMobile(mobileNumber);

            if (existingUser == null)
                return "User not found.";

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                return "Invalid Email.";

            if (string.IsNullOrWhiteSpace(address))
                return "Address is required.";

            if (string.IsNullOrWhiteSpace(password))
                return "Password is required.";

            User updatedUser = new User
            {
                MobileNumber = mobileNumber,
                Email = email,
                Address = address,
                Password = PasswordHasher.HashPassword(password),
                Role = role
            };

            bool success = _userRepository.UpdateUser(updatedUser);

            return success ? null : "Update failed.";
        }

        // ---------------- Delete User ----------------
        public string DeleteUser(string mobileNumber)
        {
            if (string.IsNullOrWhiteSpace(mobileNumber))
                return "Mobile Number is required.";

            User existingUser = _userRepository.GetUserByMobile(mobileNumber);

            if (existingUser == null)
                return "User not found.";

            bool success = _userRepository.DeleteUser(mobileNumber);

            return success ? null : "Delete failed.";
        }


        // ---------------- User Logging Credential Checking ----------------
        public User Login(string mobileNumber, string password)
        {
            string hashedPassword = PasswordHasher.HashPassword(password);

            User user = _userRepository.Login(mobileNumber, hashedPassword);

            return user;
        }
    }
}