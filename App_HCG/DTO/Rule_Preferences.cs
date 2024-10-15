using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class Rule_Preferences
    {
        private string id_rules;
        private string id_preference;
        private bool is_negated;

        public Rule_Preferences(string id_rules, string id_preference, bool is_negated)
        {
            this.Id_rules = id_rules;
            this.Id_preference = id_preference;
            this.Is_negated = is_negated;
        }
        public Rule_Preferences(DataRow row)
        {
            this.Id_rules = row["id_rules"].ToString();
            this.Id_preference = row["id_preference"].ToString();
            this.Is_negated = Convert.ToBoolean(row["is_negated"]);
        }
        public string Id_rules { get => id_rules; set => id_rules = value; }
        public string Id_preference { get => id_preference; set => id_preference = value; }
        public bool Is_negated { get => is_negated; set => is_negated = value; }
    }
}
