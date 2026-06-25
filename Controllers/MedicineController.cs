using SmartMedPharmacy.Data;
using SmartMedPharmacy.Models;
using System;
using System.Collections.Generic;

namespace SmartMedPharmacy.Controller
{
    public class MedicineController
    {
        private readonly MedicineRepository _medicineRepository;

        public MedicineController()
        {
            _medicineRepository = new MedicineRepository();
        }


        // ---------------- Save Medicine ----------------
        public string SaveMedicine(
            string name,
            int stock,
            string category,
            string supplier,
            decimal price,
            string dosage,
            DateTime expiryDate)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "Medicine name required.";

            if (stock < 0)
                return "Invalid stock.";

            if (price <= 0)
                return "Invalid price.";

            Medicine medicine = new Medicine
            {
                Name = name,
                Stock = stock,
                Category = category,
                Supplier = supplier,
                Price = price,
                Dosage = dosage,
                ExpiryDate = expiryDate
            };

            bool success = _medicineRepository.SaveMedicine(medicine);

            return success ? null : "Save failed.";
        }


        // ---------------- Get All Medicine ----------------
        public List<Medicine> GetAllMedicines()
        {
            return _medicineRepository.GetAllMedicines();
        }


        // ---------------- Search Medicine ----------------
        public Medicine SearchMedicine(string name)
        {
            return _medicineRepository.GetMedicineByName(name);
        }


        // ---------------- Update Medicine ----------------
        public string UpdateMedicine(
            string name,
            int stock,
            string category,
            string supplier,
            decimal price,
            string dosage,
            DateTime expiryDate)
        {
            Medicine medicine = new Medicine
            {
                Name = name,
                Stock = stock,
                Category = category,
                Supplier = supplier,
                Price = price,
                Dosage = dosage,
                ExpiryDate = expiryDate
            };

            bool success = _medicineRepository.UpdateMedicine(medicine);

            return success ? null : "Update failed.";
        }


        // ---------------- Delete Medicine ----------------
        public string DeleteMedicine(string name)
        {
            bool success = _medicineRepository.DeleteMedicine(name);

            return success ? null : "Delete failed.";
        }
    }
}