using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public enum MovementType
    {
        Supply,
        Withdraw,
        TransferIn,
        TransferOut
    }

    public enum SourceEntityType
    {
        Supplier,
        Client
    }

    public class ProductMovement
    {
        public int Id { get; set; }
        public int? PermitId { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int Quantity { get; set; }
        public DateTime MovementDate { get; set; }
        public MovementType MovementType { get; set; }
        public SourceEntityType? SourceEntityType { get; set; }
        public int? SourceEntityId { get; set; }
        public DateTime? ProductionDate { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public Product Product { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
