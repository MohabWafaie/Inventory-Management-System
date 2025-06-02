using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers
{
    class SupplyPermitController
    {
        private readonly ApplicationDBContext _context;
        public SupplyPermitController()
        {
            _context = new ApplicationDBContext();
        }
        // function to add a supply permit that takes a supplyPermit object and a list of data for supplypermitproducts and generates them and addt them
        public void AddSupplyPermit(SupplyPermit permit, List<(int ProductId, int Quantity, DateTime ProductionDate, DateTime ExpiryDate)> productData)
        {
            _context.SupplyPermits.Add(permit);
            _context.SaveChanges();

            SupplyPermitProductController sppc = new SupplyPermitProductController(_context);

            foreach (var item in productData)
            {
                var spp = new SupplyPermitProduct
                {
                    SupplyPermitId = permit.PermitID,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    ProductionDate = item.ProductionDate,
                    ExpiryDate = item.ExpiryDate
                };

                sppc.AddSupplyPermitProduct(spp);
            }
            _context.SaveChanges();
        }
        public List<SupplyPermit> GetAllSupplyPermits()
        {
            return _context.SupplyPermits.ToList();
        }
        public SupplyPermit GetSupplyPermitById(int id)
        {
            return _context.SupplyPermits.Find(id);
        }
        public void DeleteSupplyPermit(SupplyPermit permit)
        {
            permit = _context.SupplyPermits.Find(permit.PermitID);
            if (permit != null)
            {
                _context.SupplyPermits.Remove(permit);
                _context.SaveChanges();
            }
        }
        public void UpdateSupplyPermit(SupplyPermit permit)
        {
            _context.SupplyPermits.Update(permit);
            _context.SaveChanges();
        }
    }
}
