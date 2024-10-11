using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_HCG.DTO;

namespace App_HCG.DAO
{
    internal class PreferenceDAO
    {
        static private PreferenceDAO instance;

        public static PreferenceDAO Instance
        {
            get { if (instance == null) instance = new PreferenceDAO(); return instance; }
            private set => instance = value;
        }

        private PreferenceDAO() { }
        public List<Preference> getlistPreference()
        {
            List<Preference> list = new List<Preference>();
            string query = "select * from Preference";
            DataTable data = Connection.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Preference preference = new Preference(item);
                list.Add(preference);
            }
            return list;
        }
        public bool InsertPreference(string description)
        {
            string query = string.Format("Insert into Preference (description) values (N'{0}')", description);
            int result = Connection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdatePreference(string id, string description)
        {
            string query = string.Format("Update Preference set description = N'{0}' where id = N'{1}'", description, id);
            int result = Connection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeletePreference(string id)
        {
            string query = string.Format("Delete from Preference where id = N'{0}'", id);
            int result = Connection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
