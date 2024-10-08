using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class Student_Skills
    {
        private int student_id;
        private int skill_id;

        public Student_Skills(int student_id, int skill_id)
        {
            this.Student_id = student_id;
            this.Skill_id = skill_id;
        }
        public Student_Skills(DataRow row)
        {
            this.Student_id = Convert.ToInt32(row["student_id"]);
            this.Skill_id = Convert.ToInt32(row["skill_id"]);
        }

        public int Student_id { get => student_id; set => student_id = value; }
        public int Skill_id { get => skill_id; set => skill_id = value; }
    }
}
