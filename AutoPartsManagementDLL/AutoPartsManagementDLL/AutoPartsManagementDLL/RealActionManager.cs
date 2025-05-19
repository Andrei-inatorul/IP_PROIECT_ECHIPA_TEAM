using System.Collections.Generic;
using Items.DataBaseObjects;
using Exceptions.DataBaseExceptions;
using Items.Commons;
using AutoPartsDataManager;
using Exceptions.AccessRightsExceptions;
using System.IO;

namespace AutoPartsManagementDLL
{
    public class RealActionManager : IActionManager
    {
        private DB _db;

        public RealActionManager()
        {
            _db = DB.GetInstance("AutoParts.db");
            _db.CreateTables();
        }

        public void AddNewPart(AutoPart part)
        {
            if (part.Stock < 0)
            {
                throw new InvalidStockException("Stocul nu poate fi mai mic ca 0");
            }
            if (part.Price < 0)
            {
                throw new InvalidDataException("Prețul trebuie să fie pozitiv.");
            }

            _db.Insert(part);
        }

        public void SellPart(int partId, int quantity)
        {
            AutoPart part = _db.SelectPart(partId);
            if (part == null)
            {
                throw new RecordNotFoundException("Piesa nu a fost găsită.");
            }

            int newStock = part.Stock - quantity;
            if (newStock < 0)
            {
                throw new InvalidStockException("Stoc insuficient.");
            }

            part.Stock = newStock;
            _db.Update(part);
        }

        public void AddToStock(int partId, int quantity)
        {
            AutoPart part = _db.SelectPart(partId);
            if (part == null)
            {
                throw new RecordNotFoundException("Piesa nu a fost găsită.");
            }

            part.Stock += quantity;
            _db.Update(part);
        }

        public void UpdatePartPrice(int partId, double price)
        {
            if (price < 0)
            {
                throw new InvalidDataException("Preț invalid.");
            }

            AutoPart part = _db.SelectPart(partId);
            if (part == null)
            {
                throw new RecordNotFoundException("Piesa nu a fost găsită.");
            }

            part.Price = price;
            _db.Update(part);
        }

        public List<AutoPart> GetParts()
        {
            return _db.SelectAllParts();
        }

        public void AddUser(string username, string password, int role)
        {
            if (role != Constants.StockManager && role != Constants.SalesClerk)
            {
                throw new InvalidDataException("Rol invalid.");
            }

            int id = _db.GetLastUserID() + 1;
            string hashed = Cryptography.HashString(password);
            User user = new User(id, username, hashed, role);
            _db.Insert(user);
        }

        public void UpdateUserPassword(string username, string oldPass, string newPass)
        {
            User user = _db.SelectUser(username);
            if (user == null)
            {
                throw new RecordNotFoundException("Utilizatorul nu a fost găsit.");
            }

            string oldHash = Cryptography.HashString(oldPass);
            if (user.Password != oldHash)
            {
                throw new InvalidDataException("Parolă incorectă");
            }

            user.Password = Cryptography.HashString(newPass);
            _db.Update(user);
        }

        public User GetUser(int userId)
        {
            List<User> all = _db.SelectAllUsers();
            foreach (User u in all)
            {
                if (u.Id == userId)
                {
                    return u;
                }
            }
            throw new RecordNotFoundException("Utilizatorul nu a fost găsit.");
        }

        public void DeleteUser(string username)
        {
            User user = _db.SelectUser(username);
            if (user == null)
            {
                throw new RecordNotFoundException("Utilizatorul nu a fost găsit.");
            }
            if (user.Rights == Constants.Admin)
            {
                throw new PermissionDeniedException("Admin nu poate fi șters");
            }

            _db.DeleteUser(user.Id);
        }

        public List<User> GetUsers()
        {
            return _db.SelectAllUsers();
        }
    }
}
