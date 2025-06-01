using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class SupplyPermit
    {
        [Key]
        public int PermitID { get; set; }
        public int WarehouseId { get; set; }
        public int SupplierId { get; set; }
        public DateTime PermitDate { get; set; }

        public Supplier Supplier { get; set; }
        public Warehouse Warehouse { get; set; }
        public ICollection<SupplyPermitProduct> Products { get; set; }
    }
}
