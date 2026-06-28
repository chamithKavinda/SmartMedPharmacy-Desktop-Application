using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMedPharmacy.Models
{
    public class CartItem
    {
        public int MedicineId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal Total
        {
            get { return Price * Quantity; }
        }
    }
}
