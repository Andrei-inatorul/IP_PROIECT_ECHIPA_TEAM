using System.Collections.Generic;
using Items.DataBaseObjects;

namespace AutoPartsManagementDLL
{
    public interface IActionManager
    {
        void AddNewPart(AutoPart part);
        void SellPart(int partId, int quantity);
        void AddToStock(int partId, int quantity);
        void UpdatePartPrice(int partId, double price);
        List<AutoPart> GetParts();

        void AddUser(string username, string password, int role);
        void UpdateUserPassword(string username, string oldPass, string newPass);
        User GetUser(int userId);
        void DeleteUser(string username);
        List<User> GetUsers();
    }
}
