using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class UserSelection
    {
        private int student_id;
        private int preference_id;

        public UserSelection(int student_id, int preference_id)
        {
            this.Student_id = student_id;
            this.Preference_id = preference_id;
        }
        public UserSelection(DataRow row)
        {
            this.Student_id = int.Parse(row["student_id"].ToString());
            this.Preference_id = int.Parse(row["preference_id"].ToString());
        }

        public int Student_id { get => student_id; set => student_id = value; }
        public int Preference_id { get => preference_id; set => preference_id = value; }
    }
}
