﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG.DTO
{
    internal class Preference
    {
        private string id;
        private string description;

        public Preference(string id, string description)
        {
            this.Id = id;
            this.Description = description;
        }
        public Preference(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Description = row["description"].ToString();
        }
        public string Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
    }
}