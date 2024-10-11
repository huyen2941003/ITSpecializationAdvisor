using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App_HCG.DTO
{
    internal class Majors
    {
        private string id;
        private string name;
        private string description;

        public Majors(string id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }

        public Majors(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Name = row["name"].ToString();
            this.Description = row["description"].ToString();
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
