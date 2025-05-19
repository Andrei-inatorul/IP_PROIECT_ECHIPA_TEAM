using System.Collections.Generic;
using Items.DataBaseObjects;
using Exceptions.DataBaseExceptions;
using Exceptions.AccessRightsExceptions;
using Items.Commons;
using AutoPartsDataManager;

namespace AutoPartsManagementDLL
{
    public class ProxyActionManager : IActionManager
    {
        private static ProxyActionManager _instance = null;
        private DB _db;
        private RealActionManager _realManager;
        private User _currentUser;
        private Permissions _permissions;

        private ProxyActionManager()
        {
            _db = DB.GetInstance("AutoParts.db");
            _realManager = new RealActionManager();
            _permissions = new Permissions();
        }

        public static ProxyActionManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ProxyActionManager();
            }
            return _instance;
        }

        public User CurrentUser
        {
            get { return _currentUser; }
        }

        public bool Login(string username, string password)
        {
            List<User> users = _db.SelectAllUsers();
            string hashedPassword = Cryptography.HashString(password);

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Username == username && users[i].Password == hashedPassword)
                {
                    _currentUser = users[i];
                    return true;
                }
            }

            return false;
        }

        public void AddNewPart(AutoPart part)
        {
            if (!HasRight(Constants.ModifyPartsDBRight))
            {
                throw new PermissionDeniedException();
            }

            _realManager.AddNewPart(part);
        }

        public void SellPart(int partId, int quantity)
        {
            if (!HasRight(Constants.SellRight))
            {
                throw new PermissionDeniedException();
            }

            _realManager.SellPart(partId, quantity);
        }

        public void AddToStock(int partId, int quantity)
        {
            if (!HasRight(Constants.ModifyPartsDBRight))
            {
                throw new PermissionDeniedException();
            }

            _realManager.AddToStock(partId, quantity);
        }

        public void UpdatePartPrice(int partId, double price)
        {
            if (!HasRight(Constants.ModifyPartsDBRight))
            {
                throw new PermissionDeniedException();
            }

            _realManager.UpdatePartPrice(partId, price);
        }

        public List<AutoPart> GetParts()
        {
            if (!HasRight(Constants.ViewPartsRight))
            {
                throw new PermissionDeniedException();
            }

            return _realManager.GetParts();
        }

        public void AddUser(string username, string password, int role)
        {
            if (!HasRight(Constants.ModifyUsersDBRight))
            {
                throw new PermissionDeniedException();
            }

            _realManager.AddUser(username, password, role);
        }

        public void UpdateUserPassword(string username, string oldPass, string newPass)
        {
            if (!HasRight(Constants.ModifyUsersDBRight))
            {
                throw new PermissionDeniedException();
            }

            _realManager.UpdateUserPassword(username, oldPass, newPass);
        }

        public User GetUser(int userId)
        {
            if (!HasRight(Constants.ViewUsersRight))
            {
                throw new PermissionDeniedException();
            }

            return _realManager.GetUser(userId);
        }

        public void DeleteUser(string username)
        {
            if (!HasRight(Constants.ModifyUsersDBRight))
            {
                throw new PermissionDeniedException();
            }

            _realManager.DeleteUser(username);
        }

        public List<User> GetUsers()
        {
            if (!HasRight(Constants.ViewUsersRight))
            {
                throw new PermissionDeniedException();
            }

            return _realManager.GetUsers();
        }

        public bool IsAdmin()
        {
            return _currentUser != null && _currentUser.Rights == Constants.Admin;
        }

        private bool HasRight(int right)
        {
            List<int> rights = _permissions.RightsList(_currentUser.Rights);
            for (int i = 0; i < rights.Count; i++)
            {
                if (rights[i] == right)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
