using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class ProductInWarehouse
    {
        [Key]
        public int StockId { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int Quantity { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Product Product { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
