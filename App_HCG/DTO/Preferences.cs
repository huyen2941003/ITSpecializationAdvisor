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
        private string id_majors;
        public Preferences(string id, string description, string id_majors)
        {
            this.Id = id;
            this.Description = description;
            this.Id_Majors = id_majors;
        }
        public Preferences(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Description = row["description"].ToString();
            this.Id_Majors = row["id_majors"].ToString();
        }
        public string Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public string Id_Majors { get => id_majors; set => id_majors = value; }

    }
}
