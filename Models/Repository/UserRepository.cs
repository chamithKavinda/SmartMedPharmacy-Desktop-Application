using MySql.Data.MySqlClient;
using SmartMedPharmacy.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SmartMedPharmacy.Data
{
    public class UserRepository
    {

        // ---------------- Save User ----------------
        public bool RegisterUser(User user)
        {
            string query = @"INSERT INTO Users 
                (MobileNumber, Email, Address, Password, Role)
                VALUES (@MobileNumber, @Email, @Address, @Password, @Role)";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MobileNumber", user.MobileNumber);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ---------------- Get All Users ----------------
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            string query = "SELECT * FROM Users";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            MobileNumber = reader["MobileNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            Address = reader["Address"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString()
                        });
                    }
                }
            }

            return users;
        }

        // ---------------- Search User ----------------
        public User GetUserByMobile(string mobileNumber)
        {
            string query = "SELECT * FROM Users WHERE MobileNumber = @MobileNumber";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MobileNumber", mobileNumber);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            MobileNumber = reader["MobileNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            Address = reader["Address"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString()
                        };
                    }
                }
            }

            return null;
        }

        // ---------------- Update User ----------------
        public bool UpdateUser(User user)
        {
            string query = @"UPDATE Users SET 
                Email = @Email,
                Address = @Address,
                Password = @Password,
                Role = @Role
                WHERE MobileNumber = @MobileNumber";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MobileNumber", user.MobileNumber);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ---------------- Delete User ----------------
        public bool DeleteUser(string mobileNumber)
        {
            string query = "DELETE FROM Users WHERE MobileNumber = @MobileNumber";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MobileNumber", mobileNumber);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ---------------- Check Already Saved User  ----------------
        public bool MobileNumberExists(string mobileNumber)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE MobileNumber = @MobileNumber";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MobileNumber", mobileNumber);

                conn.Open();
                long count = Convert.ToInt64(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public bool EmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                long count = Convert.ToInt64(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        // ---------------- User Loggin Credential Checking  ----------------
        public User Login(string mobileNumber, string passwordHash)
        {
            string query = "SELECT * FROM Users WHERE MobileNumber = @MobileNumber AND Password = @Password";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MobileNumber", mobileNumber);
                cmd.Parameters.AddWithValue("@Password", passwordHash);

                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            MobileNumber = reader["MobileNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            Address = reader["Address"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString()
                        };
                    }
                }
            }

            return null;
        }

        // ---------------- Duplicate Email Checking  ----------------
        public bool EmailExistsForAnotherUser(string email, string mobileNumber)
        {
            string query = @"SELECT COUNT(*)
                     FROM Users
                     WHERE Email = @Email
                     AND MobileNumber <> @MobileNumber";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@MobileNumber", mobileNumber);

                conn.Open();

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
    }
}