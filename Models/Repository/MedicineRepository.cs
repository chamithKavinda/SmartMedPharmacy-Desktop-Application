using MySql.Data.MySqlClient;
using SmartMedPharmacy.Models;
using System;
using System.Collections.Generic;

namespace SmartMedPharmacy.Data
{
    public class MedicineRepository
    {
        // ---------------- Save Medicine ----------------
        public bool SaveMedicine(Medicine medicine)
        {
            string query = @"INSERT INTO Medicines
                (Name, Stock, Category, Supplier, Price, Dosage, ExpiryDate)
                VALUES
                (@Name, @Stock, @Category, @Supplier, @Price, @Dosage, @ExpiryDate)";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", medicine.Name);
                cmd.Parameters.AddWithValue("@Stock", medicine.Stock);
                cmd.Parameters.AddWithValue("@Category", medicine.Category);
                cmd.Parameters.AddWithValue("@Supplier", medicine.Supplier);
                cmd.Parameters.AddWithValue("@Price", medicine.Price);
                cmd.Parameters.AddWithValue("@Dosage", medicine.Dosage);
                cmd.Parameters.AddWithValue("@ExpiryDate", medicine.ExpiryDate);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }


        // ---------------- Get All Medicine ----------------
        public List<Medicine> GetAllMedicines()
        {
            List<Medicine> medicines = new List<Medicine>();

            string query = "SELECT * FROM Medicines";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        medicines.Add(new Medicine
                        {
                            MedicineId = Convert.ToInt32(reader["MedicineId"]),
                            Name = reader["Name"].ToString(),
                            Stock = Convert.ToInt32(reader["Stock"]),
                            Category = reader["Category"].ToString(),
                            Supplier = reader["Supplier"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            Dosage = reader["Dosage"].ToString(),
                            ExpiryDate = Convert.ToDateTime(reader["ExpiryDate"])
                        });
                    }
                }
            }

            return medicines;
        }


        // ---------------- Search Medicine ----------------
        public Medicine GetMedicineByName(string name)
        {
            string query = "SELECT * FROM Medicines WHERE Name=@Name";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", name);

                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Medicine
                        {
                            MedicineId = Convert.ToInt32(reader["MedicineId"]),
                            Name = reader["Name"].ToString(),
                            Stock = Convert.ToInt32(reader["Stock"]),
                            Category = reader["Category"].ToString(),
                            Supplier = reader["Supplier"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            Dosage = reader["Dosage"].ToString(),
                            ExpiryDate = Convert.ToDateTime(reader["ExpiryDate"])
                        };
                    }
                }
            }

            return null;
        }


        // ---------------- Update Medicine ----------------
        public bool UpdateMedicine(Medicine medicine)
        {
            string query = @"UPDATE Medicines SET
                            Stock=@Stock,
                            Category=@Category,
                            Supplier=@Supplier,
                            Price=@Price,
                            Dosage=@Dosage,
                            ExpiryDate=@ExpiryDate
                            WHERE Name=@Name";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", medicine.Name);
                cmd.Parameters.AddWithValue("@Stock", medicine.Stock);
                cmd.Parameters.AddWithValue("@Category", medicine.Category);
                cmd.Parameters.AddWithValue("@Supplier", medicine.Supplier);
                cmd.Parameters.AddWithValue("@Price", medicine.Price);
                cmd.Parameters.AddWithValue("@Dosage", medicine.Dosage);
                cmd.Parameters.AddWithValue("@ExpiryDate", medicine.ExpiryDate);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }


        // ---------------- Delete Medicine ----------------
        public bool DeleteMedicine(string name)
        {
            string query = "DELETE FROM Medicines WHERE Name=@Name";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", name);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}