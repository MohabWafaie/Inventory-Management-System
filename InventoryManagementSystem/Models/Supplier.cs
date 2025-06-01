using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Models
{
    public class Supplier : Person
    {
        public DbSet<SupplyPermit> SupplyPermits { get; set; }
        public DbSet<TransferPermit> TransferPermits { get; set; }
    }
}
