using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers
{
    public class SupplyPermitProductController
    {
        private readonly ApplicationDBContext _context;
        public SupplyPermitProductController()
        {
            _context = new ApplicationDBContext();
        }
        public SupplyPermitProductController(ApplicationDBContext context)
        {
            _context = context;
        }
        public void AddSupplyPermitProduct(SupplyPermitProduct supplyPermitProduct)
        {
            if (supplyPermitProduct == null)
                throw new ArgumentNullException(nameof(supplyPermitProduct));
            _context.supplyPermitProducts.Add(supplyPermitProduct);
            ProductInWarehouseController pwc = new ProductInWarehouseController(_context);
            ProductInWarehouse productInWarehouse = new ProductInWarehouse
            {
                ProductId = supplyPermitProduct.ProductId,
                WarehouseId = supplyPermitProduct.SupplyPermit.WarehouseId,
                Quantity = supplyPermitProduct.Quantity,
                EntryDate = supplyPermitProduct.SupplyPermit.PermitDate,
                ProductionDate = supplyPermitProduct.ProductionDate,
                ExpiryDate = supplyPermitProduct.ExpiryDate
            };
            pwc.AddProductInWarehouse(productInWarehouse);
            ProductMovementController pmc = new ProductMovementController(_context);
            ProductMovement productMovement = new ProductMovement
            {
                PermitId = supplyPermitProduct.SupplyPermitId,
                ProductId = supplyPermitProduct.ProductId,
                WarehouseId = supplyPermitProduct.SupplyPermit.WarehouseId,
                Quantity = supplyPermitProduct.Quantity,
                MovementDate = supplyPermitProduct.SupplyPermit.PermitDate,
                MovementType = MovementType.Supply,
                SourceEntityType = SourceEntityType.Supplier,
                SourceEntityId = supplyPermitProduct.SupplyPermit.SupplierId,
                ProductionDate = supplyPermitProduct.ProductionDate,
                ExpiryDate = supplyPermitProduct.ExpiryDate
            };
            pmc.AddProductMovement(productMovement);
            _context.SaveChanges();
        }
        public List<SupplyPermitProduct> GetAllSupplyPermitProducts()
        {
            return _context.supplyPermitProducts.ToList();
        }
        public SupplyPermitProduct GetSupplyPermitProductById(int permitId, int productId)
        {
            return _context.supplyPermitProducts.Find(permitId, productId);
        }

        public void UpdateSupplyPermitProduct(SupplyPermitProduct supplyPermitProduct)
        {
            if (supplyPermitProduct == null)
                throw new ArgumentNullException(nameof(supplyPermitProduct));
            _context.supplyPermitProducts.Update(supplyPermitProduct);
            _context.SaveChanges();
        }
        public void DeleteSupplyPermitProduct(int permitId, int productId)
        {
            var supplyPermitProduct = _context.supplyPermitProducts.Find(permitId, productId);
            if (supplyPermitProduct != null)
            {
                _context.supplyPermitProducts.Remove(supplyPermitProduct);
                _context.SaveChanges();
            }
        }
    }
}
