using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class Consultation_Results
    {
        private int result_id;
        private int student_id;
        private int major_id;
        private DateTime consultation_date;
        private string comments;

        public Consultation_Results(int result_id, int student_id, int major_id, DateTime consultation_date, string comments)
        {
            this.Result_id = result_id;
            this.Student_id = student_id;
            this.Major_id = major_id;
            this.Consultation_date = consultation_date;
            this.Comments = comments;
        }
        public Consultation_Results(DataRow row)
        {
            this.Result_id = Convert.ToInt32(row["result_id"]);
            this.Student_id = Convert.ToInt32(row["student_id"]);
            this.Major_id = Convert.ToInt32(row["major_id"]);
            this.Consultation_date = Convert.ToDateTime(row["consultation_date"]);
            this.Comments = row["comments"].ToString();
        }

        public int Result_id { get => result_id; set => result_id = value; }
        public int Student_id { get => student_id; set => student_id = value; }
        public int Major_id { get => major_id; set => major_id = value; }
        public DateTime Consultation_date { get => consultation_date; set => consultation_date = value; }
        public string Comments { get => comments; set => comments = value; }
    }
}
