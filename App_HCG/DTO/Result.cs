using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class Result
    {
        private int result_id;
        private string result_code;
        private string result_description;

        public Result(int result_id, string result_code, string result_description)
        {
            this.Result_id = result_id;
            this.Result_code = result_code;
            this.Result_description = result_description;
        }
        public Result(DataRow row)
        {
            this.Result_id = int.Parse(row["result_id"].ToString());
            this.Result_code = row["result_code"].ToString();
            this.Result_description = row["result_description"].ToString();
        }

        public int Result_id { get => result_id; set => result_id = value; }
        public string Result_code { get => result_code; set => result_code = value; }
        public string Result_description { get => result_description; set => result_description = value; }
    }
}
