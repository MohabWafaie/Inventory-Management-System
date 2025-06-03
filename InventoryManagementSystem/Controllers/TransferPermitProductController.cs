using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers
{
    public class TransferPermitProductController
    {
        private readonly ApplicationDBContext _context;
        public TransferPermitProductController()
        {
            _context = new ApplicationDBContext();
        }
        public TransferPermitProductController(ApplicationDBContext context)
        {
            _context = context;
        }
        public void AddTransferPermitProduct(TransferPermitProduct transferPermitProduct)
        {
            if (transferPermitProduct == null)
                throw new ArgumentNullException(nameof(transferPermitProduct));
            _context.transferPermitProducts.Add(transferPermitProduct);
            ProductInWarehouseController pwc = new ProductInWarehouseController(_context);

            // add transfer permit product to the destination warehouse
            ProductInWarehouse productInWarehouse = new ProductInWarehouse
            {
                ProductId = transferPermitProduct.ProductId,
                WarehouseId = transferPermitProduct.TransferPermit.DestinationWarehouseId,
                Quantity = transferPermitProduct.Quantity,
                EntryDate = transferPermitProduct.TransferPermit.PermitDate,
                ProductionDate = transferPermitProduct.ProductionDate,
                ExpiryDate = transferPermitProduct.ExpiryDate
            };
            pwc.AddProductInWarehouse(productInWarehouse);

            // remove transfer permit product from the source warehouse
            var productInWarehouse2 = pwc.GetProductInWarehouseById(transferPermitProduct.StockID);
            productInWarehouse.Quantity -= transferPermitProduct.Quantity;
            pwc.UpdateProductInWarehouse(productInWarehouse2);

            // add transferIN movement
            ProductMovementController pmc = new ProductMovementController(_context);
            ProductMovement productMovement = new ProductMovement
            {
                PermitId = transferPermitProduct.TransferPermitId,
                ProductId = transferPermitProduct.ProductId,
                WarehouseId = transferPermitProduct.TransferPermit.DestinationWarehouseId,
                Quantity = transferPermitProduct.Quantity,
                MovementDate = transferPermitProduct.TransferPermit.PermitDate,
                MovementType = MovementType.TransferIn,
                SourceEntityType = SourceEntityType.Supplier,
                SourceEntityId = transferPermitProduct.TransferPermit.SupplierID,
                ProductionDate = transferPermitProduct.ProductionDate,
                ExpiryDate = transferPermitProduct.ExpiryDate
            };
            pmc.AddProductMovement(productMovement);

            // add transferOUT movement
            var productMovement1 = new ProductMovement
            {
                PermitId = transferPermitProduct.TransferPermitId,
                ProductId = transferPermitProduct.ProductId,
                WarehouseId = transferPermitProduct.TransferPermit.SourceWarehouseId,
                Quantity = -transferPermitProduct.Quantity, // Withdraw = negative quantity
                MovementDate = transferPermitProduct.TransferPermit.PermitDate,
                MovementType = MovementType.TransferOut,
                SourceEntityType = SourceEntityType.Supplier,
                SourceEntityId = transferPermitProduct.TransferPermit.SupplierID
            };
            pmc.AddProductMovement(productMovement1);

            _context.SaveChanges();
        }
        public List<TransferPermitProduct> GetAllTransferPermitProducts()
        {
            return _context.transferPermitProducts.ToList();
        }
        public TransferPermitProduct GetTransferPermitProductById(int permitId, int productId)
        {
            return _context.transferPermitProducts
                .FirstOrDefault(tpp => tpp.TransferPermitId == permitId && tpp.ProductId == productId);
        }
        public void UpdateTransferPermitProduct(TransferPermitProduct transferPermitProduct)
        {
            if (transferPermitProduct == null)
                throw new ArgumentNullException(nameof(transferPermitProduct));
            _context.transferPermitProducts.Update(transferPermitProduct);
            _context.SaveChanges();
        }
        public void DeleteTransferPermitProduct(int permitId, int productId)
        {
            var transferPermitProduct = GetTransferPermitProductById(permitId, productId);
            if (transferPermitProduct != null)
            {
                _context.transferPermitProducts.Remove(transferPermitProduct);
                _context.SaveChanges();
            }
        }
    }
}
