using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using static InventoryManagementSystem.UserControllers.UserControl6;


namespace InventoryManagementSystem.Controllers
{
    public class ProductInWarehouseController
    {
        private readonly ApplicationDBContext _context;
        public ProductInWarehouseController()
        {
            _context = new ApplicationDBContext();
        }
        public ProductInWarehouseController(ApplicationDBContext context)
        {
            _context = context;
        }
        public void AddProductInWarehouse(ProductInWarehouse productInWarehouse)
        {
            if (productInWarehouse == null)
                throw new ArgumentNullException(nameof(productInWarehouse));
            _context.productInWarehouses.Add(productInWarehouse);
            _context.SaveChanges();
        }
        public List<ProductInWarehouse> GetAllProductsInWarehouse()
        {
            return _context.productInWarehouses
                .Include(p => p.Product)
                .ToList();
        }
        public ProductInWarehouse GetProductInWarehouseById(int id)
        {
            return _context.productInWarehouses.Find(id);
        }
        public void UpdateProductInWarehouse(ProductInWarehouse productInWarehouse)
        {
            if (productInWarehouse == null)
                throw new ArgumentNullException(nameof(productInWarehouse));
            _context.productInWarehouses.Update(productInWarehouse);
            _context.SaveChanges();
        }
        public void DeleteProductInWarehouse(int id)
        {
            var productInWarehouse = _context.productInWarehouses.Find(id);
            if (productInWarehouse != null)
            {
                _context.productInWarehouses.Remove(productInWarehouse);
                _context.SaveChanges();
            }
        }
        public List<ProductDisplayItem> GetProductsWithTotalQuantity()
        {
            var productsInWarehouses = _context.productInWarehouses
                .Include(p => p.Product)
                .ToList();

            var groupedProducts = productsInWarehouses
                .Where(p => p.Product != null)
                .GroupBy(p => new { p.ProductId, p.Product.Name, p.WarehouseId })
                .Select(g => new ProductDisplayItem
                {
                    ProductID = g.Key.ProductId,
                    WarehouseId = g.Key.WarehouseId,
                    Display = $"{g.Key.Name} - {g.Sum(p => p.Quantity)} in stock",
                    TotalQuantity = g.Sum(p => p.Quantity)
                })
                .OrderByDescending(p => p.TotalQuantity)
                .ToList();

            return groupedProducts;
        }
    }
}
