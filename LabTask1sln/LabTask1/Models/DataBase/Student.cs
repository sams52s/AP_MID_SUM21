using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LabTask1.Models.DataBase
{
    public class Student
    {
        SqlConnection conn;
        public Student(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Insert(Student s)
        {

        }
        public void Get(int id)
        {

        }
        public void Show()
        {

        }
        public void Edit(Student s)
        {

        }
        public void Delete(Student s)
        {

        }
    }
}