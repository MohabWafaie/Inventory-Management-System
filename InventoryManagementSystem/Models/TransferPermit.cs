using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class TransferPermit
    {
        [Key]
        public int PermitID { get; set; }
        public int SupplierID { get; set; }
        public int SourceWarehouseId { get; set; }
        public int DestinationWarehouseId { get; set; }
        public DateTime PermitDate { get; set; }

        public Supplier Supplier { get; set; }
        public Warehouse SourceWarehouse { get; set; }
        public Warehouse DestinationWarehouse { get; set; }
        public List<TransferPermitProduct> Products { get; set; }
    }
}
