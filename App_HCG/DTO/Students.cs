using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class Students
    {
        private int student_id;
        private string name;
        private string email;
        private string phone;
        private DateTime dateOfBirth;
        private char gender;
        private string preferences;

        public Students(int student_id, string name, string email, string phone, DateTime dateOfBirth, char gender, string preferences)
        {
            this.Student_id = student_id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Preferences = preferences;
        }
        public Students(DataRow row)
        {
            this.Student_id = Convert.ToInt32(row["student_id"]);
            this.Name = row["name"].ToString();
            this.Email = row["email"].ToString();
            this.Phone = row["phone"].ToString();
            this.DateOfBirth = Convert.ToDateTime(row["date_of_birth"]);
            this.Gender = Convert.ToChar(row["gender"]);
            this.Preferences = row["preferences"].ToString();
        }
        public int Student_id { get => student_id; set => student_id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Preferences { get => preferences; set => preferences = value; }
    }
}
