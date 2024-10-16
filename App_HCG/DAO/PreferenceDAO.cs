using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
        public List<Preferences> getlistPreferences()
        {
            List<Preferences> list = new List<Preferences>();
            string query = "select * from Preferences";
            DataTable data = Connection.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Preferences preferences = new Preferences(item);
                list.Add(preferences);
            }
            return list;
        }
        public bool InsertPreferences(string description)
        {
            string query = string.Format("Insert into Preferences (description) values (N'{0}')", description);
            int result = Connection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdatePreferences(string id, string description)
        {
            string query = string.Format("Update Preferences set description = N'{0}' where id = N'{1}'", description, id);
            int result = Connection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeletePreferences(string id)
        {
            string query = string.Format("Delete from Preferences where id = N'{0}'", id);
            int result = Connection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Preferences> Search(string description)
        {
            List<Preferences> list = new List<Preferences>();
            string query = string.Format("Select * from Preferences where description like N'%{0}%'", description);
            DataTable data = Connection.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Preferences preferences = new Preferences(item);
                list.Add(preferences);
            }
            return list;
        }
    }
}
