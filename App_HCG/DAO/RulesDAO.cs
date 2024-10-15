using App_HCG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
