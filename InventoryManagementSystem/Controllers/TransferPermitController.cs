using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers
{
    public class TransferPermitController
    {
        private readonly ApplicationDBContext _context;
        public TransferPermitController()
        {
            _context = new ApplicationDBContext();
        }
        public TransferPermitController(ApplicationDBContext context)
        {
            _context = context;
        }
        public void AddTransferPermit(TransferPermit permit, List<(int ProductId, int Quantity, DateTime ProductionDate, DateTime ExpiryDate)> productData)
        {
            _context.TransferPermits.Add(permit);
            _context.SaveChanges();
            TransferPermitProductController tppc = new TransferPermitProductController(_context);
            ProductInWarehouseController pwc = new ProductInWarehouseController(_context);
            var data = pwc.GetAllProductsInWarehouse();

            foreach (var item in productData)
            {
                int remainingQuantity = item.Quantity;

                // Retrieve stock records for the product ordered by ExpiryDate ascending
                var stocks = (from s in data
                              where s.ProductId == item.ProductId && s.Quantity > 0
                              orderby s.ExpiryDate
                              select s).ToList();

                foreach (var stock in stocks)
                {
                    if (remainingQuantity <= 0)
                        break;

                    int withdrawQty = Math.Min(stock.Quantity, remainingQuantity);

                    // Create a TransferPermitProduct entry
                    var tpp = new TransferPermitProduct
                    {
                        TransferPermitId = permit.PermitID,
                        ProductId = item.ProductId,
                        StockID = stock.StockId,
                        Quantity = withdrawQty,
                        ProductionDate = item.ProductionDate,
                        ExpiryDate = item.ExpiryDate
                    };
                    tppc.AddTransferPermitProduct(tpp);
                    remainingQuantity -= withdrawQty;
                }
                if (remainingQuantity > 0)
                {
                    throw new InvalidOperationException($"Not enough stock for product ID {item.ProductId}. Requested: {item.Quantity}, Available: {item.Quantity - remainingQuantity}.");
                }
            }
            _context.SaveChanges();
        }
        public List<TransferPermit> GetAllTransferPermits()
        {
            return _context.TransferPermits.ToList();
        }
        public TransferPermit GetTransferPermitById(int id)
        {
            return _context.TransferPermits.Find(id);
        }
        public void DeleteTransferPermit(TransferPermit permit)
        {
            permit = _context.TransferPermits.Find(permit.PermitID);
            if (permit != null)
            {
                _context.TransferPermits.Remove(permit);
                _context.SaveChanges();
            }
        }
        public void UpdateTransferPermit(TransferPermit permit)
        {
            _context.TransferPermits.Update(permit);
            _context.SaveChanges();
        }
    }
}
