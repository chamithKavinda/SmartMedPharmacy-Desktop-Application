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
        public string SaveMedicine(string name,int stock,string category,string supplier,decimal price,string dosage,DateTime expiryDate)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "Medicine name required.";

            if (stock < 0)
                return "Stock cannot be negative.";

            if (string.IsNullOrWhiteSpace(category))
                return "Medicine category required.";

            if (string.IsNullOrWhiteSpace(supplier))
                return "Supplier required.";

            if (price <= 0)
                return "Price must be greater than zero.";

            if (string.IsNullOrWhiteSpace(dosage))
                return "Dosage required.";

            if (expiryDate <= DateTime.Today)
                return "Expiry date must be a future date.";

            Medicine medicine = new Medicine
            {
                Name = name.Trim(),
                Stock = stock,
                Category = category,
                Supplier = supplier.Trim(),
                Price = price,
                Dosage = dosage.Trim(),
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
            if (string.IsNullOrWhiteSpace(name))
                return null;

            return _medicineRepository.GetMedicineByName(name.Trim());
        }

        // ---------------- Update Medicine ----------------
        public string UpdateMedicine(string name,int stock,string category,string supplier,decimal price,string dosage,DateTime expiryDate)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "Medicine name required.";

            if (stock < 0)
                return "Invalid stock.";

            if (string.IsNullOrWhiteSpace(category))
                return "Category required.";

            if (string.IsNullOrWhiteSpace(supplier))
                return "Supplier required.";

            if (price <= 0)
                return "Invalid price.";

            if (string.IsNullOrWhiteSpace(dosage))
                return "Dosage required.";

            if (expiryDate <= DateTime.Today)
                return "Expiry date must be future date.";

            Medicine medicine = new Medicine
            {
                Name = name.Trim(),
                Stock = stock,
                Category = category,
                Supplier = supplier.Trim(),
                Price = price,
                Dosage = dosage.Trim(),
                ExpiryDate = expiryDate
            };

            bool success = _medicineRepository.UpdateMedicine(medicine);

            return success ? null : "Update failed.";
        }

        // ---------------- Delete Medicine ----------------
        public string DeleteMedicine(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "Medicine name required.";

            bool success = _medicineRepository.DeleteMedicine(name.Trim());

            return success ? null : "Delete failed.";
        }

        public List<Medicine> CheckExpiringMedicines(int daysThreshold = 30)
        {
            return _medicineRepository.GetExpiringMedicines(daysThreshold);
        }
    }
}