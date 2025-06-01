using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class SupplyPermitProduct
    {
        public int SupplyPermitId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public SupplyPermit SupplyPermit { get; set; }
        public Product Product { get; set; }
    }
}
