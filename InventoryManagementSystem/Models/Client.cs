using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Models
{
    public class Client : Person
    {
        public DbSet<WithdrawPermit> WithdrawPermits { get; set; }
    }
}
