using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Lab_14
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string DNI { get; set; }
        public string first_name { get; set; }
        public string lasT_name { get; set; }

        public string date { get; set; }
    }
}
