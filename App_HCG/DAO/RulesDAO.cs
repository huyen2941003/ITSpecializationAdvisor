using App_HCG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DAO
{
    internal class RulesDAO
    {
        static private RulesDAO instance;
        public static RulesDAO Instance
        {
            get { if (instance == null) instance = new RulesDAO(); return instance; }
            private set => instance = value;
        }
        private RulesDAO() { }
        public List<Rules> getlistRules()
        {
            List<Rules> list = new List<Rules>();
            string query = "select * from Rules";
            DataTable data = Connection.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Rules rules = new Rules(item);
                list.Add(rules);
            }
            return list;
        }
        public string GetRulesString()
        {
            string query = "SELECT TOP 1 ruleS FROM Rules";
            DataTable data = Connection.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["ruleS"].ToString();
            }
            else
            {
                return string.Empty;
            }
        }
        public string GetRulesString2(string id)
        {
            string query = string.Format("SELECT description FROM Rules R where RuleS = N'{0}'", id);
            DataTable data = Connection.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["description"].ToString();
            }
            else
            {
                return string.Empty;
            }
        }
        public Dictionary<string, int> GetMajorCounts(List<string> preferenceIds)
        {
            Dictionary<string, int> majorCount = new Dictionary<string, int>();

            // Tạo chuỗi chứa các ID preference để sử dụng trong truy vấn
            string preferencesCommaSeparated = string.Join(",", preferenceIds.Select(id => $"'{id}'"));
            string query = $@"
                            SELECT m.id AS MajorId, m.name AS MajorName, COUNT(*) AS PreferenceCount
                            FROM Preferences p
                            JOIN Majors m ON p.id_majors = m.id
                            WHERE p.id IN ({preferencesCommaSeparated})
                            GROUP BY m.id, m.name
                            ORDER BY PreferenceCount DESC;";
            DataTable data = Connection.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                string majorId = row["MajorId"].ToString();
                string majorName = row["MajorName"].ToString();
                int count = Convert.ToInt32(row["PreferenceCount"]);
                majorCount[majorName] = count;
            }

            return majorCount;
        }
        public string GetMajorsString(string id)
        {
            List<string> ruleList = new List<string>();
            string query = string.Format("SELECT M.name as id_majors " +
                           "FROM Rules R " +
                           "LEFT JOIN Majors M ON M.id = R.id_majors where R.id_majors = N'{0}'", id);
            DataTable data = Connection.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["id_majors"].ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public List<Rules> GetList_Rules()
        {
            List<Rules> list = new List<Rules>();
            string query = "SELECT * FROM Rules";
            DataTable data = Connection.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Rules rules = new Rules(item);
                list.Add(rules);
            }
            return list;
        }

        public bool InsertRules(string ruleS, string id_Majors, string description)
        {
            string query = string.Format("Insert into Rules (ruleS, id_Majors, description) VALUES (N'{0} → {1}', '{1}', N'{2}')", 
                ruleS, id_Majors, description);
            int result = Connection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteRules(string id)
        {
            string query = string.Format("Delete from Rules where id = N'{0}'", id);
            int result = Connection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateRules(string id, string ruleS, string id_Majors, string description)
        {
            string query = string.Format("Update Rules set ruleS = N'{0}', id_Majors = N'{1}', description = N'{2}' where id = N'{3}'",
                ruleS, id_Majors, description, id);
            int result = Connection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        
    }
}
