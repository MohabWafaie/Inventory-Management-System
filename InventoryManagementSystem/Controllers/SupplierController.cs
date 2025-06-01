using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers
{
    class SupplierController
    {
        private readonly ApplicationDBContext _context;
        public SupplierController()
        {
            _context = new ApplicationDBContext();
        }
        public List<Supplier> GetAllSuppliers()
        {
            return _context.Suppliers.ToList();
        }
        public Supplier GetSupplierById(int id)
        {
            return _context.Suppliers.Find(id);
        }
        public void AddSupplier(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }
        public void DeleteSupplier(Supplier supplier)
        {
            supplier = _context.Suppliers.Find(supplier.ID);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                _context.SaveChanges();
            }
        }
        public void UpdateSupplier(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            _context.SaveChanges();
        }
    }
}
