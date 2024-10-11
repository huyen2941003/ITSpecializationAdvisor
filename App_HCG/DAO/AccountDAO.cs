using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using App_HCG.DTO;

namespace App_HCG.DAO
{
    internal class AccountDAO
    {
        static private AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value;
        }
        private AccountDAO() { }
        public List<Account> Login(string username, string password_hash)
        {
            List<Account> list = new List<Account>();
            string query = string.Format("select * from Account where username = N'{0}' and password_hash = N'{1}'",
                username, password_hash);
            DataTable data = Connection.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }
            return list;
        }
        public bool InsertAccount(string name, string username, string password_hash)
        {
            string query = string.Format("Insert into Account (name, username, password_hash, role) values (N'{0}', N'{1}', N'{2}', 1)",
                name, username, password_hash);
            int result = Connection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Account> SetInsert(string username)
        {
            List<Account> list = new List<Account>();
            string query = string.Format("Select * from Account where username = N'{0}'",
                username);
            DataTable data = Connection.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }
            return list;
        }
    }
}
