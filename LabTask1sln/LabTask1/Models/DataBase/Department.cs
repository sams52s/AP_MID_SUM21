using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LabTask1.Models.DataBase
{
    public class Department
    {
        SqlConnection conn;
        public Department(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Get(int id)
        {

        }
        public void Show()
        {

        }
    }
}