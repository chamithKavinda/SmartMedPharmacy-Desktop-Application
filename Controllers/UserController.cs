using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        // ---------------- Register User ----------------
        public string Register(string mobileNumber, string email,
                               string address, string password, string role)
        {
            if (string.IsNullOrWhiteSpace(mobileNumber))
                return "Mobile Number is required.";

            if (mobileNumber.Length != 10)
                return "Mobile Number must contain exactly 10 digits.";

            if (!mobileNumber.All(char.IsDigit))
                return "Mobile Number must contain only numbers.";

            if (string.IsNullOrWhiteSpace(email))
                return "Email is required.";

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, emailPattern))
                return "Invalid Email Address.";

            if (string.IsNullOrWhiteSpace(address))
                return "Address is required.";

            if (address.Trim().Length < 5)
                return "Address is too short.";

            if (string.IsNullOrWhiteSpace(password))
                return "Password is required.";

            if (password.Length < 8)
                return "Password must be at least 8 characters.";

            if (!password.Any(char.IsUpper))
                return "Password must contain at least one uppercase letter.";

            if (!password.Any(char.IsLower))
                return "Password must contain at least one lowercase letter.";

            if (!password.Any(char.IsDigit))
                return "Password must contain at least one number.";

            if (string.IsNullOrWhiteSpace(role))
                return "Role is required.";

            if (role != "Admin" &&
                role != "Customer" &&
                role != "Pharmacist")
            {
                return "Invalid role selected.";
            }

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

        // ---------------- Get All Users ----------------
        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        // ---------------- Search User ----------------
        public User GetUserByMobile(string mobileNumber)
        {
            if (string.IsNullOrWhiteSpace(mobileNumber))
                return null;

            return _userRepository.GetUserByMobile(mobileNumber);
        }

        // ---------------- Update User ----------------
        public string UpdateUser(string mobileNumber,
                                 string email,
                                 string address,
                                 string password,
                                 string role,
                                 bool passwordChanged)
        {
            User existingUser =
                _userRepository.GetUserByMobile(mobileNumber);

            if (existingUser == null)
                return "User not found.";

            if (string.IsNullOrWhiteSpace(email))
                return "Email is required.";

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, emailPattern))
                return "Invalid Email Address.";

            if (_userRepository.EmailExistsForAnotherUser(email, mobileNumber))
                return "Email already exists.";

            if (string.IsNullOrWhiteSpace(address))
                return "Address is required.";

            if (address.Trim().Length < 5)
                return "Address is too short.";

            if (string.IsNullOrWhiteSpace(role))
                return "Role is required.";

            if (role != "Admin" &&
                role != "Customer" &&
                role != "Pharmacist")
            {
                return "Invalid role selected.";
            }

            string finalPassword = existingUser.Password;

            if (passwordChanged)
            {
                if (string.IsNullOrWhiteSpace(password))
                    return "Password is required.";

                if (password.Length < 8)
                    return "Password must be at least 8 characters.";

                if (!password.Any(char.IsUpper))
                    return "Password must contain at least one uppercase letter.";

                if (!password.Any(char.IsLower))
                    return "Password must contain at least one lowercase letter.";

                if (!password.Any(char.IsDigit))
                    return "Password must contain at least one number.";

                finalPassword =
                    PasswordHasher.HashPassword(password);
            }

            User updatedUser = new User
            {
                MobileNumber = mobileNumber,
                Email = email,
                Address = address,
                Password = finalPassword,
                Role = role
            };

            bool success =
                _userRepository.UpdateUser(updatedUser);

            return success ? null : "Update failed.";
        }

        // ---------------- Delete User ----------------
        public string DeleteUser(string mobileNumber)
        {
            if (string.IsNullOrWhiteSpace(mobileNumber))
                return "Mobile Number is required.";

            User existingUser =
                _userRepository.GetUserByMobile(mobileNumber);

            if (existingUser == null)
                return "User not found.";

            bool success =
                _userRepository.DeleteUser(mobileNumber);

            return success ? null : "Delete failed.";
        }

        // ---------------- Login ----------------
        public User Login(string mobileNumber, string password)
        {
            if (string.IsNullOrWhiteSpace(mobileNumber))
                return null;

            if (mobileNumber.Length != 10)
                return null;

            if (!mobileNumber.All(char.IsDigit))
                return null;

            if (string.IsNullOrWhiteSpace(password))
                return null;

            string hashedPassword =
                PasswordHasher.HashPassword(password);

            return _userRepository.Login(mobileNumber, hashedPassword);
        }
    }
}