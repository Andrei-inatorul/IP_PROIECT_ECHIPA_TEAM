using System.Collections.Generic;

namespace AutoPartsManagementDLL
{
    public class Permissions
    {
        private Dictionary<int, List<int>> _permissionsList;

        public Permissions()
        {
            _permissionsList = new Dictionary<int, List<int>>();
            _permissionsList.Add(Constants.SalesClerk, new List<int> { Constants.SellRight, Constants.ViewPartsRight });
            _permissionsList.Add(Constants.StockManager, new List<int> { Constants.SellRight, Constants.ViewPartsRight, Constants.ModifyPartsDBRight });
            _permissionsList.Add(Constants.Admin, new List<int> { Constants.ModifyUsersDBRight, Constants.ViewUsersRight });
        }

        public List<int> RightsList(int role)
        {
            if (_permissionsList.ContainsKey(role))
            {
                return _permissionsList[role];
            }
            return new List<int>();
        }
    }
}