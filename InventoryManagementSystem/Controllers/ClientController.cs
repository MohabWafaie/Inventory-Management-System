using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers
{
    class ClientController
    {
        ApplicationDBContext _context;
        public ClientController()
        {
            _context = new ApplicationDBContext();
        }
        public void AddClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }
        public List<Client> GetAllClients()
        {
            return _context.Clients.ToList();
        }
        public Client GetClientById(int id)
        {
            return _context.Clients.Find(id);
        }
        public void UpdateClient(Client client)
        {
            _context.Clients.Update(client);
            _context.SaveChanges();
        }
        public void DeleteClient(int id)
        {
            var client = _context.Clients.Find(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
        }
    }
}
