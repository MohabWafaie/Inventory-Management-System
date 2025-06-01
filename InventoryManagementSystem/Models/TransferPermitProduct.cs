using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class TransferPermitProduct
    {
        public int TransferPermitId { get; set; }
        public int StockID { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }


        public TransferPermit TransferPermit { get; set; }
        public ProductInWarehouse Stock { get; set; }
        public Product Product { get; set; }
    }
}
