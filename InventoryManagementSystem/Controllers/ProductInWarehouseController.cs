using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

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
            return _context.productInWarehouses.ToList();
        }
        public ProductInWarehouse GetProductInWarehouseById(int id)
        {
            return _context.productInWarehouses.Find(id);
        }
        public void UpdateProductInWarehouse(ProductInWarehouse productInWarehouse)
        {
            if (productInWarehouse == null)
                throw new ArgumentNullException(nameof(productInWarehouse));
            if (productInWarehouse.Quantity == 0)
            {
                DeleteProductInWarehouse(productInWarehouse.StockId);
            }
            else
            {
                _context.productInWarehouses.Update(productInWarehouse);
            }
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
    }
}
