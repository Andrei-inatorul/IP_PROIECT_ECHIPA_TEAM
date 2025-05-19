namespace Items.DataBaseObjects
{
    public class User
    {
        private int _id;
        private string _username;
        private string _password;
        private int _rights;

        public User(int id, string username, string password, int rights)
        {
            _id = id;
            _username = username;
            _password = password;
            _rights = rights;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Username { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public int Rights { get { return _rights; } set { _rights = value; } }

        public string ToString()
        {
            return _id + " " + _username + " " + _password + " " + _rights;
        }
    }
}