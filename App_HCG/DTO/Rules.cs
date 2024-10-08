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
        private int rule_id;
        private int major_id;
        private string rule_expression;
        private string description;

        public Rules(int rule_id, int major_id, string rule_expression, string description)
        {
            this.Rule_id = rule_id;
            this.Major_id = major_id;
            this.Rule_expression = rule_expression;
            this.Description = description;
        }
        public Rules(DataRow row)
        {
            this.Rule_id = Convert.ToInt32(row["rule_id"]);
            this.Major_id = Convert.ToInt32(row["major_id"]);
            this.Rule_expression = row["rule_expression"].ToString();
            this.Description = row["description"].ToString();
        }

        public int Rule_id { get => rule_id; set => rule_id = value; }
        public int Major_id { get => major_id; set => major_id = value; }
        public string Rule_expression { get => rule_expression; set => rule_expression = value; }
        public string Description { get => description; set => description = value; }
    }
}
