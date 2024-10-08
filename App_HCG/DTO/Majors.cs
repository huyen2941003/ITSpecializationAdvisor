using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class Majors
    {
        private int major_id;
        private string major_name;
        private string description;
        private string requirements;

        public Majors(int major_id, string major_name, string description, string requirements)
        {
            this.Major_id = major_id;
            this.Major_name = major_name;
            this.Description = description;
            this.Requirements = requirements;
        }
        public Majors(DataRow row)
        {
            this.Major_id = Convert.ToInt32(row["major_id"]);
            this.Major_name = row["major_name"].ToString();
            this.Description = row["description"].ToString();
            this.Requirements = row["requirements"].ToString();
        }

        public int Major_id { get => major_id; set => major_id = value; }
        public string Major_name { get => major_name; set => major_name = value; }
        public string Description { get => description; set => description = value; }
        public string Requirements { get => requirements; set => requirements = value; }
    }
}
