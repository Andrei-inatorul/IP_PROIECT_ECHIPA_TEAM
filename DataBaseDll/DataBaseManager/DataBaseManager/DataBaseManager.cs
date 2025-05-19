using Exceptions.DataBaseExceptions;
using Items.DataBaseObjects;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace AutoPartsDataManager
{
    public class DB
    {
        private SQLiteConnection _connection;
        private static DB instance = null;

        private DB(string dbName)
        {
            if (Path.GetExtension(dbName) != ".db")
            {
                throw new InvalidExtensionException();
            }

            _connection = new SQLiteConnection("Data Source=" + dbName + "; Version=3; New=True; Compress=True;");
            try
            {
                _connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static DB GetInstance(string dbName)
        {
            if (instance == null)
            {
                instance = new DB(dbName);
            }

            if (dbName.Substring(0, dbName.Length - 3) != instance._connection.DataSource)
            {
                instance.ChangeConnection(dbName);
            }

            return instance;
        }

        public SQLiteConnection Connection
        {
            get { return _connection; }
        }

        public void ChangeConnection(string dbName)
        {
            if (Path.GetExtension(dbName) != ".db")
            {
                throw new InvalidExtensionException();
            }

            _connection.Close();
            _connection = new SQLiteConnection("Data Source=" + dbName + "; Version=3; New=True; Compress=True;");
            try
            {
                _connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateTables()
        {
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='USERS'";
            SQLiteDataReader reader = command.ExecuteReader();
            string userTable = "";
            while (reader.Read())
            {
                userTable += reader.GetString(0);
            }

            if (userTable == "")
            {
                string createUsers = "CREATE TABLE USERS (id INT PRIMARY KEY, username TEXT UNIQUE, password TEXT NOT NULL, rights INT NOT NULL)";
                command = _connection.CreateCommand();
                command.CommandText = createUsers;
                command.ExecuteNonQuery();
            }

            command = _connection.CreateCommand();
            command.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='AUTOPARTS'";
            reader = command.ExecuteReader();
            string partsTable = "";
            while (reader.Read())
            {
                partsTable += reader.GetString(0);
            }

            if (partsTable == "")
            {
                string createParts = "CREATE TABLE AUTOPARTS (id INT PRIMARY KEY, name TEXT UNIQUE, brand TEXT, price DOUBLE, stock INT)";
                command = _connection.CreateCommand();
                command.CommandText = createParts;
                command.ExecuteNonQuery();
            }
        }

        public void Insert(User user)
        {
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT id FROM USERS WHERE id=" + user.Id;
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read()) throw new ConstraintViolatedException();

            command = _connection.CreateCommand();
            command.CommandText = "SELECT username FROM USERS WHERE username='" + user.Username + "'";
            reader = command.ExecuteReader();
            if (reader.Read()) throw new ConstraintViolatedException();

            command = _connection.CreateCommand();
            command.CommandText = "INSERT INTO USERS(id, username, password, rights) VALUES(" + user.Id + ", '" + user.Username + "', '" + user.Password + "', " + user.Rights + ")";
            command.ExecuteNonQuery();
        }

        public void Insert(AutoPart part)
        {
            if (part.Stock < 0) throw new InvalidStockException();

            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT id FROM AUTOPARTS WHERE id=" + part.Id;
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read()) throw new ConstraintViolatedException();

            command = _connection.CreateCommand();
            command.CommandText = "SELECT name FROM AUTOPARTS WHERE name='" + part.Name + "'";
            reader = command.ExecuteReader();
            if (reader.Read()) throw new ConstraintViolatedException();

            command = _connection.CreateCommand();
            command.CommandText = "INSERT INTO AUTOPARTS(id, name, brand, price, stock) VALUES(" +
                                  part.Id + ", '" + part.Name + "', '" + part.Brand + "', " + part.Price + ", " + part.Stock + ")";
            command.ExecuteNonQuery();
        }

        public List<User> SelectAllUsers()
        {
            List<User> users = new List<User>();
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT * FROM USERS";
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
            }

            return users;
        }

        public List<AutoPart> SelectAllParts()
        {
            List<AutoPart> parts = new List<AutoPart>();
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT * FROM AUTOPARTS";
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                parts.Add(new AutoPart(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetInt32(4)));
            }

            return parts;
        }

        public User SelectUser(string username)
        {
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT * FROM USERS WHERE username='" + username + "'";
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
            }

            return null;
        }

        public AutoPart SelectPart(int id)
        {
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT * FROM AUTOPARTS WHERE id=" + id;
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new AutoPart(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetInt32(4));
            }

            return null;
        }

        public void Update(User user)
        {
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "UPDATE USERS SET username='" + user.Username + "', password='" + user.Password + "', rights=" + user.Rights + " WHERE id=" + user.Id;
            int result = command.ExecuteNonQuery();
            if (result == 0) throw new RecordNotFoundException();
        }

        public void Update(AutoPart part)
        {
            if (part.Stock < 0) throw new InvalidStockException();

            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "UPDATE AUTOPARTS SET name='" + part.Name + "', brand='" + part.Brand + "', price=" + part.Price + ", stock=" + part.Stock + " WHERE id=" + part.Id;
            int result = command.ExecuteNonQuery();
            if (result == 0) throw new RecordNotFoundException();
        }

        public void DeleteUser(int id)
        {
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "DELETE FROM USERS WHERE id=" + id;
            command.ExecuteNonQuery();
        }

        public void DeletePart(int id)
        {
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "DELETE FROM AUTOPARTS WHERE id=" + id;
            command.ExecuteNonQuery();
        }

        public void ClearUsers()
        {
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "DELETE FROM USERS";
            command.ExecuteNonQuery();
        }

        public void ClearParts()
        {
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "DELETE FROM AUTOPARTS";
            command.ExecuteNonQuery();
        }

        public int GetLastUserID()
        {
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT MAX(id) FROM USERS";
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read() && !reader.IsDBNull(0))
            {
                return reader.GetInt32(0);
            }
            return -1;
        }

        public int GetLastPartID()
        {
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT MAX(id) FROM AUTOPARTS";
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read() && !reader.IsDBNull(0))
            {
                return reader.GetInt32(0);
            }
            return -1;
        }
    }
}
