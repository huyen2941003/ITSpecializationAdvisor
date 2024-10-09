using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class Student
    {
        private int student_id;
        private string student_name;
        private string student_email;
        private string student_major;
        private int admin_id;

        public Student(int student_id, string student_name, string student_email, string student_major, int admin_id)
        {
            this.Student_id = student_id;
            this.Student_name = student_name;
            this.Student_email = student_email;
            this.Student_major = student_major;
            this.Admin_id = admin_id;
        }
        public Student(DataRow row)
        {
            this.Student_id = int.Parse(row["student_id"].ToString());
            this.Student_name = row["student_name"].ToString();
            this.Student_email = row["student_email"].ToString();
            this.Student_major = row["student_major"].ToString();
            this.Admin_id = int.Parse(row["admin_id"].ToString());
        }

        public int Student_id { get => Student_id; set => Student_id = value; }
        public string Student_name { get => Student_name; set => Student_name = value; }
        public string Student_email { get => Student_email; set => Student_email = value; }
        public string Student_major { get => Student_major; set => Student_major = value; }
        public int Admin_id { get => Admin_id; set => Admin_id = value; }

    }
}
