using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class Account
    {
        private int id;
        private string name;
        private string username;
        private string password_hash;
        private int role;

        public Account(int id, string name, string username, string password_hash, int role)
        {
            this.Id = id;
            this.Name = name;
            this.Username = username;
            this.Password_hash = password_hash;
            this.Role = role;
        }
        public Account(DataRow row)
        {
            this.Id = int.Parse(row["id"].ToString());
            this.Name = row["name"].ToString();
            this.Username = row["username"].ToString();
            this.Password_hash = row["password_hash"].ToString();
            this.Role = int.Parse(row["role"].ToString());
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password_hash { get => password_hash; set => password_hash = value; }
        public int Role { get => role; set => role = value; }
    }
}
