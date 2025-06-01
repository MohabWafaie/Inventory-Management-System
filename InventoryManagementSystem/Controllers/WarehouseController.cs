using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers
{
    public class WarehouseController
    {
        private readonly ApplicationDBContext _context;
        public WarehouseController()
        {
            _context = new ApplicationDBContext();
        }
        public void AddWarehouse(Warehouse warehouse)
        {
            _context.Warehouses.Add(warehouse);
            _context.SaveChanges();
        }
        public List<Warehouse> GetAllWarehouses()
        {
            return _context.Warehouses.ToList();
        }
        public Warehouse GetWarehouseById(int id)
        {
            return _context.Warehouses.Find(id);
        }
        public void UpdateWarehouse(Warehouse warehouse)
        {
            _context.Warehouses.Update(warehouse);
            _context.SaveChanges();
        }
        public void DeleteWarehouse(int id)
        {
            var warehouse = _context.Warehouses.Find(id);
            if (warehouse != null)
            {
                _context.Warehouses.Remove(warehouse);
                _context.SaveChanges();
            }
        }
    }
}
