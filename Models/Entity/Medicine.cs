using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMedPharmacy.Models
{
    public class Medicine
    {
        public int MedicineId { get; set; }

        public string Name { get; set; }

        public int Stock { get; set; }

        public string Category { get; set; }

        public string Supplier { get; set; }

        public decimal Price { get; set; }

        public string Dosage { get; set; }

        public DateTime ExpiryDate { get; set; }
    }
}
