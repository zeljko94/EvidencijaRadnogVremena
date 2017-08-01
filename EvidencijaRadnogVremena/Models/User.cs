using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleCounterNg.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long EmployeeId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deleted { get; set; }
        public DateTime Updated { get; set; }
        public long CompanyId { get; set; }
        public string Privileges { get; set; }

        public User()
        {

        }

        public static User GetById(int id)
        {
            User user = null;
            MySQLDatabase db = new MySQLDatabase();
            db.ConnectToKnokErp();
            Dictionary<string, object> procParams = new Dictionary<string, object>();
            procParams.Add("_userId", id);
            MySqlDataReader reader = db.ExecuteStoredProcedure("UsersGetById", procParams);
            while (reader.Read())
            {
                user = new User()
                {
                    UserId = !reader.IsDBNull(reader.GetOrdinal("UserId")) ? reader.GetInt64(reader.GetOrdinal("UserId")) : 0,
                    Username = !reader.IsDBNull(reader.GetOrdinal("Username")) ? reader.GetString(reader.GetOrdinal("Username")) : "",
                    Password = !reader.IsDBNull(reader.GetOrdinal("Password")) ? reader.GetString(reader.GetOrdinal("Password")) : "",
                    EmployeeId = !reader.IsDBNull(reader.GetOrdinal("EmployeeId")) ? reader.GetInt64(reader.GetOrdinal("EmployeeId")) : 0,
                    IsDeleted = !reader.IsDBNull(reader.GetOrdinal("IsDeleted")) ? reader.GetBoolean(reader.GetOrdinal("IsDeleted")) : false,
                    Created = !reader.IsDBNull(reader.GetOrdinal("Created")) ? reader.GetDateTime(reader.GetOrdinal("Created")) : new DateTime(),
                    Deleted = !reader.IsDBNull(reader.GetOrdinal("Deleted")) ? reader.GetDateTime(reader.GetOrdinal("Deleted")) : new DateTime(),
                    Updated = !reader.IsDBNull(reader.GetOrdinal("Updated")) ? reader.GetDateTime(reader.GetOrdinal("Updated")) : new DateTime(),
                    CompanyId = !reader.IsDBNull(reader.GetOrdinal("CompanyId")) ? reader.GetInt64(reader.GetOrdinal("CompanyId")) : 0,
                    Privileges = !reader.IsDBNull(reader.GetOrdinal("Privileges")) ? reader.GetString(reader.GetOrdinal("Privileges")) : ""
                };
            }
            db.CloseConnection();
            return user;
        }
        public static List<User> GetAll()
        {
            List<User> users = new List<User>();
            MySQLDatabase db = new MySQLDatabase();
            db.ConnectToKnokErp();
            Dictionary<string, object> procParams = new Dictionary<string, object>();
            MySqlDataReader reader = db.ExecuteStoredProcedure("UsersGetAll", procParams);
            while (reader.Read())
            {
                users.Add(new User()
                {
                    UserId = !reader.IsDBNull(reader.GetOrdinal("UserId")) ? reader.GetInt64(reader.GetOrdinal("UserId")) : 0,
                    Username = !reader.IsDBNull(reader.GetOrdinal("Username")) ? reader.GetString(reader.GetOrdinal("Username")) : "",
                    Password = !reader.IsDBNull(reader.GetOrdinal("Password")) ? reader.GetString(reader.GetOrdinal("Password")) : "",
                    EmployeeId = !reader.IsDBNull(reader.GetOrdinal("EmployeeId")) ? reader.GetInt64(reader.GetOrdinal("EmployeeId")) : 0,
                    IsDeleted = !reader.IsDBNull(reader.GetOrdinal("IsDeleted")) ? reader.GetBoolean(reader.GetOrdinal("IsDeleted")) : false,
                    Created = !reader.IsDBNull(reader.GetOrdinal("Created")) ? reader.GetDateTime(reader.GetOrdinal("Created")) : new DateTime(),
                    Deleted = !reader.IsDBNull(reader.GetOrdinal("Deleted")) ? reader.GetDateTime(reader.GetOrdinal("Deleted")) : new DateTime(),
                    Updated = !reader.IsDBNull(reader.GetOrdinal("Updated")) ? reader.GetDateTime(reader.GetOrdinal("Updated")) : new DateTime(),
                    CompanyId = !reader.IsDBNull(reader.GetOrdinal("CompanyId")) ? reader.GetInt64(reader.GetOrdinal("CompanyId")) : 0,
                    Privileges = !reader.IsDBNull(reader.GetOrdinal("Privileges")) ? reader.GetString(reader.GetOrdinal("Privileges")) : ""
                });
            }
            db.CloseConnection();
            return users;
        }

        public void Delete()
        {
            MySQLDatabase db = new MySQLDatabase();
            db.ConnectToKnokErp();
            Dictionary<string, object> procParams = new Dictionary<string, object>();
            procParams.Add("uid", this.UserId);
            db.ExecuteStoredProcedure("UsersDelete", procParams);
            db.CloseConnection();
        }
        public void Insert()
        {
            MySQLDatabase db = new MySQLDatabase();
            db.ConnectToKnokErp();
            Dictionary<string, object> procParams = new Dictionary<string, object>();
            procParams.Add("u", this.Username);
            procParams.Add("p", this.Password);
            procParams.Add("isDel", this.IsDeleted);
            procParams.Add("created", this.Created);
            procParams.Add("updated", this.Updated);
            procParams.Add("deleted", this.Deleted);
            procParams.Add("compId", this.CompanyId);
            procParams.Add("privileges", this.Privileges);
            db.ExecuteStoredProcedure("UsersInsert", procParams);
            db.CloseConnection();
        }

        public void Update()
        {
            MySQLDatabase db = new MySQLDatabase();
            db.ConnectToKnokErp();
            Dictionary<string, object> procParams = new Dictionary<string, object>();
            procParams.Add("_userId", this.UserId);
            procParams.Add("_username", this.Username);
            procParams.Add("_password", this.Password);
            procParams.Add("_isDeleted", this.IsDeleted);
            procParams.Add("_created", this.Created);
            procParams.Add("_updated", this.Updated);
            procParams.Add("_deleted", this.Deleted);
            procParams.Add("_companyId", this.CompanyId);
            procParams.Add("_privileges", this.Privileges);
            db.ExecuteStoredProcedure("UsersUpdate", procParams);
            db.CloseConnection();
        }

        public void UpdateAdmin()
        {
            MySQLDatabase db = new MySQLDatabase();
            db.ConnectToKnokErp();
            Dictionary<string, object> procParams = new Dictionary<string, object>();
            procParams.Add("_userId", this.UserId);
            procParams.Add("_username", this.Username);
            procParams.Add("_password", this.Password);
            procParams.Add("_isDeleted", this.IsDeleted);
            procParams.Add("_created", this.Created);
            procParams.Add("_updated", this.Updated);
            procParams.Add("_deleted", this.Deleted);
            procParams.Add("_privileges", this.Privileges);
            db.ExecuteStoredProcedure("UsersUpdatePeopleCounterAdmin", procParams);
            db.CloseConnection();
        }

        public void InsertAdmin()
        {
            MySQLDatabase db = new MySQLDatabase();
            db.ConnectToKnokErp();
            Dictionary<string, object> procParams = new Dictionary<string, object>();
            procParams.Add("u", this.Username);
            procParams.Add("p", this.Password);
            procParams.Add("isDel", this.IsDeleted);
            procParams.Add("created", this.Created);
            procParams.Add("updated", this.Updated);
            procParams.Add("deleted", this.Deleted);
            procParams.Add("privileges", this.Privileges);
            db.ExecuteStoredProcedure("UsersInsertPeopleCounterAdmin", procParams);
            db.CloseConnection();
        }
        public static User logiraj(string username, string password)
        {
            User user = null;
            MySQLDatabase db = new MySQLDatabase();
            db.ConnectToKnokErp();
            Dictionary<string, object> procParams = new Dictionary<string, object>();
            procParams.Add("u", username);
            procParams.Add("p", password);
            MySqlDataReader reader = db.ExecuteStoredProcedure("GetUserByUsernameAndPassword", procParams);
            while (reader.Read())
            {
                user = new User()
                {
                    UserId = !reader.IsDBNull(reader.GetOrdinal("UserId")) ? reader.GetInt64(reader.GetOrdinal("UserId")) : 0,
                    Username = !reader.IsDBNull(reader.GetOrdinal("Username")) ? reader.GetString(reader.GetOrdinal("Username")) : "",
                    Password = !reader.IsDBNull(reader.GetOrdinal("Password")) ? reader.GetString(reader.GetOrdinal("Password")) : "",
                    EmployeeId = !reader.IsDBNull(reader.GetOrdinal("EmployeeId")) ? reader.GetInt64(reader.GetOrdinal("EmployeeId")) : 0,
                    IsDeleted = !reader.IsDBNull(reader.GetOrdinal("IsDeleted")) ? reader.GetBoolean(reader.GetOrdinal("IsDeleted")) : false,
                    Created = !reader.IsDBNull(reader.GetOrdinal("Created")) ? reader.GetDateTime(reader.GetOrdinal("Created")) : new DateTime(),
                    Deleted = !reader.IsDBNull(reader.GetOrdinal("Deleted")) ? reader.GetDateTime(reader.GetOrdinal("Deleted")) : new DateTime(),
                    Updated = !reader.IsDBNull(reader.GetOrdinal("Updated")) ? reader.GetDateTime(reader.GetOrdinal("Updated")) : new DateTime(),
                    CompanyId = !reader.IsDBNull(reader.GetOrdinal("CompanyId")) ? reader.GetInt64(reader.GetOrdinal("CompanyId")) : 0,
                    Privileges = !reader.IsDBNull(reader.GetOrdinal("Privileges")) ? reader.GetString(reader.GetOrdinal("Privileges")) : ""
                };
            }
            db.CloseConnection();
            return user;
        }
    }
}