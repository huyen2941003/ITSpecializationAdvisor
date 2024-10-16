using App_HCG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Rule_Preferences> GetList_RulePreferences()
        {
            List<Rule_Preferences> list = new List<Rule_Preferences>();
            string query = "SELECT * FROM Rule_Preferences";
            DataTable data = Connection.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Rule_Preferences rulePreference = new Rule_Preferences(item);
                list.Add(rulePreference);
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
        public bool DeleteRule_Preferences(string id_rules)
        {
            string query = string.Format("Delete from Rule_Preferences where id_rules = N'{0}'", id_rules);
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
