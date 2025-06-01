using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class WithdrawPermit
    {
        [Key]
        public int PermitID { get; set; }
        public int WarehouseId { get; set; }
        public int ClientId { get; set; }
        public DateTime PermitDate { get; set; }


        public Warehouse Warehouse { get; set; }
        public Client Client { get; set; }
        public ICollection<WithdrawPermitProduct> Products { get; set; }
    }
}
