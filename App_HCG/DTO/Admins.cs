using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class Admins
    {
        private int admin_id;
        private string username;
        private string password;
        private string role;

        public Admins(int admin_id, string username, string password, string role)
        {
            this.Admin_id = admin_id;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }
        public Admins(DataRow row)
        {
            this.Admin_id = Convert.ToInt32(row["admin_id"]);
            this.Username = row["username"].ToString();
            this.Password = row["password"].ToString();
            this.Role = row["role"].ToString();
        }
        public int Admin_id { get => admin_id; set => admin_id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
