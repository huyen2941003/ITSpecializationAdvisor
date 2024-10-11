using App_HCG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DAO
{
    internal class MajorsDAO
    {
        static private MajorsDAO instance;

        public static MajorsDAO Instance
        {
            get { if (instance == null) instance = new MajorsDAO(); return instance; }
            private set => instance = value;
        }
        private MajorsDAO() { }
        public List<Majors> getlistMajors()
        {
            List<Majors> list = new List<Majors>();
            string query = "select * from Majors";
            DataTable data = Connection.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Majors majors = new Majors(item);
                list.Add(majors);
            }
            return list;
        }
        public bool InsertMajors(string name, string description)
        {
            string query = string.Format("Insert into Majors (name, description) values (N'{0}, N'{1}')", 
                name, description);
            int result = Connection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateMajors(string id, string name, string description)
        {
            string query = string.Format("Update Majors set name = N'{0}', description = N'{1}' where id = N'{2}'",
                name, description, id);
            int result = Connection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteMajors(string id)
        {
            string query = string.Format("Delete from Majors where id = N'{0}'", id);
            int result = Connection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
