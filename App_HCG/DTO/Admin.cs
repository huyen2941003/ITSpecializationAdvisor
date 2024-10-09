using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class Admin
    {
        private int admin_id;
        private string username;
        private string password_hash;

        public Admin(int admin_id, string username, string password_hash)
        {
            this.Admin_id = admin_id;
            this.Username = username;
            this.Password_hash = password_hash;
        }
        public Admin(DataRow row)
        {
            this.Admin_id = int.Parse(row["admin_id"].ToString());
            this.Username = row["username"].ToString();
            this.Password_hash = row["password_hash"].ToString();
        }

        public int Admin_id { get => admin_id; set => admin_id = value; }
        public string Username { get => username; set => username = value; }
        public string Password_hash { get => password_hash; set => password_hash = value; }
    }
}
