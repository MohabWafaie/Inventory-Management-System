using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers
{
    class WithdrawPermitProductController
    {
        private readonly ApplicationDBContext _context;
        public WithdrawPermitProductController()
        {
            _context = new ApplicationDBContext();
        }
        public WithdrawPermitProductController(ApplicationDBContext context)
        {
            _context = context;
        }
        public void AddWithdrawPermitProduct(WithdrawPermitProduct withdrawPermitProduct)
        {
            if (withdrawPermitProduct == null)
                throw new ArgumentNullException(nameof(withdrawPermitProduct));

            // Ensure WithdrawPermit is loaded from the database
            var permit = _context.WithdrawPermits
                                 .FirstOrDefault(wp => wp.PermitID == withdrawPermitProduct.WithdrawPermitId);

            if (permit == null)
                throw new InvalidOperationException("Withdraw permit not found.");

            withdrawPermitProduct.WithdrawPermit = permit;

            // Add the WithdrawPermitProduct
            _context.WithdrawPermitProducts.Add(withdrawPermitProduct);

            // Update ProductInWarehouse stock
            var pwc = new ProductInWarehouseController(_context);
            var productInWarehouse = pwc.GetProductInWarehouseById(withdrawPermitProduct.StockID);
            productInWarehouse.Quantity -= withdrawPermitProduct.Quantity;
            pwc.UpdateProductInWarehouse(productInWarehouse);

            // Log Product Movement
            var pmc = new ProductMovementController(_context);
            var productMovement = new ProductMovement
            {
                PermitId = withdrawPermitProduct.WithdrawPermitId,
                ProductId = withdrawPermitProduct.ProductId,
                WarehouseId = permit.WarehouseId,
                Quantity = -withdrawPermitProduct.Quantity, // Withdraw = negative quantity
                MovementDate = permit.PermitDate,
                MovementType = MovementType.Withdraw,
                SourceEntityType = SourceEntityType.Client,
                SourceEntityId = permit.ClientId
            };
            pmc.AddProductMovement(productMovement);

            _context.SaveChanges();
        }

        public List<WithdrawPermitProduct> GetAllWithdrawPermitProducts()
        {
            return _context.WithdrawPermitProducts.ToList();
        }
        public WithdrawPermitProduct GetWithdrawPermitProductById(int permitId, int productId)
        {
            return _context.WithdrawPermitProducts.Find(permitId, productId);
        }
        public void UpdateWithdrawPermitProduct(WithdrawPermitProduct withdrawPermitProduct)
        {
            if (withdrawPermitProduct == null)
                throw new ArgumentNullException(nameof(withdrawPermitProduct));
            _context.WithdrawPermitProducts.Update(withdrawPermitProduct);
            _context.SaveChanges();
        }
        public void DeleteWithdrawPermitProduct(int permitId, int productId)
        {
            var withdrawPermitProduct = _context.WithdrawPermitProducts.Find(permitId, productId);
            if (withdrawPermitProduct != null)
            {
                _context.WithdrawPermitProducts.Remove(withdrawPermitProduct);
                _context.SaveChanges();
            }
        }
    }
}
