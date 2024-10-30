using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class Rules
    {
        private string id;
        private string ruleS;
        private string id_majors;
        private string description;

        public Rules(string id, string ruleS, string id_majors, string description)
        {
            this.Id = id;
            this.RuleS = ruleS;
            this.Id_Majors = id_majors;
            this.Description = description;
        }
        public Rules(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.RuleS = row["ruleS"].ToString();
            this.Id_Majors = row["id_majors"].ToString();
            this.Description = row["description"].ToString();
        }

        public string Id { get => id; set => id = value; }
        public string RuleS { get => ruleS; set => ruleS = value; }
        public string Id_Majors { get => id_majors; set => id_majors = value; }
        public string Description { get => description; set => description = value; }
    }
}
