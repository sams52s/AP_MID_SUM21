using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LabTask1.Models.DataBase
{
    public class Database
    {
        public Student Student { get; set; }
        public Admin Admin { get; set; }
        public Department Department { get; set; }
        public Database()
        {
            string connString = @"Server=DESKTOP-4BCMUD5;Database=ASPMVCLabTask1;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            Student = new Student(conn);
            Admin = new Admin(conn);

        }
    }
}