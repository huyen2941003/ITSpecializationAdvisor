using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class Skills_Preferences
    {
        private int skill_id;
        private string skill_name;
        private string description;

        public Skills_Preferences(int skill_id, string skill_name, string description)
        {
            this.Skill_id = skill_id;
            this.Skill_name = skill_name;
            this.Description = description;
        }
        public Skills_Preferences(DataRow row)
        {
            this.Skill_id = Convert.ToInt32(row["skill_id"]);
            this.Skill_name = row["skill_name"].ToString();
            this.Description = row["description"].ToString();
        }

        public int Skill_id { get => skill_id; set => skill_id = value; }
        public string Skill_name { get => skill_name; set => skill_name = value; }
        public string Description { get => description; set => description = value; }
    }
}
