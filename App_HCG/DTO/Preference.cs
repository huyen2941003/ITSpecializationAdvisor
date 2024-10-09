using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class Preference
    {
        private int preference_id;
        private string preference_description;
        private int result_id;

        public Preference(int preference_id, string preference_description, int result_id)
        {
            this.Preference_id = preference_id;
            this.Preference_description = preference_description;
            this.Result_id = result_id;
        }
        public Preference(DataRow row)
        {
            this.Preference_id = int.Parse(row["preference_id"].ToString());
            this.Preference_description = row["preference_description"].ToString();
            this.Result_id = int.Parse(row["result_id"].ToString());
        }
        public int Preference_id { get => preference_id; set => preference_id = value; }
        public string Preference_description { get => preference_description; set => preference_description = value; }
        public int Result_id { get => result_id; set => result_id = value; }
    }
}
