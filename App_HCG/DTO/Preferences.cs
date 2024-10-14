using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class Preferences
    {
        private string id;
        private string description;

        public Preferences(string id, string description)
        {
            this.Id = id;
            this.Description = description;
        }
        public Preferences(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Description = row["description"].ToString();
        }
        public string Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
    }
}
