using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LabTask1.Models.DataBase
{
    public class Database
    {
        public Student student { get; set; }
        public Admin admin { get; set; }
        public Department department { get; set; }
        public Database()
        {
            string connString = @"Server=DESKTOP-4BCMUD5;Database=ASPMVCLabTask1;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            student = new Student(conn);
            admin = new Admin(conn);
        }
    }
}