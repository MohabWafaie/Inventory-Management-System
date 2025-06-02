using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;


namespace InventoryManagementSystem.Controllers
{
    public class ProductMovementController
    {
        private readonly ApplicationDBContext _context;
        public ProductMovementController()
        {
            _context = new ApplicationDBContext();
        }
        public ProductMovementController(ApplicationDBContext context)
        {
            _context = context;
        }
        public void AddProductMovement(ProductMovement productMovement)
        {
            if (productMovement == null)
                throw new ArgumentNullException(nameof(productMovement));
            _context.ProductMovements.Add(productMovement);
            _context.SaveChanges();
        }
        public List<ProductMovement> GetProductMovements()
        {
            return _context.ProductMovements
                .Include(pm => pm.Warehouse)
                .Include(pm => pm.Product)
                .ToList();
        }
        public ProductMovement GetProductMovementById(int id)
        {
            return _context.ProductMovements.FirstOrDefault(pm => pm.Id == id);
        }
        public void UpdateProductMovement(ProductMovement productMovement)
        {
            _context.ProductMovements.Update(productMovement);
            _context.SaveChanges();
        }
        public void DeleteProductMovement(int id)
        {
            var productMovement = GetProductMovementById(id);
            if (productMovement != null)
            {
                _context.ProductMovements.Remove(productMovement);
                _context.SaveChanges();
            }
        }
    }
}
