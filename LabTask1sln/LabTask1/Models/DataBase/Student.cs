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
        public void Insert(StudentModel s)
        {
            string query = "Insert into Student values(@Id,@Name,@DoB,@CGPA,@Credit,@DepID)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", s.ID);
            cmd.Parameters.AddWithValue("@name", s.Name);
            cmd.Parameters.AddWithValue("@DoB", s.DoB);
            cmd.Parameters.AddWithValue("@CGPA", s.CGPA);
            cmd.Parameters.AddWithValue("@Credit", s.Credit);
            cmd.Parameters.AddWithValue("@DepID", s.Credit);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<StudentModel> Get()
        {
            List<StudentModel> StudentModel = new List<StudentModel>();
            string query = "select * from Student";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    StudentModel s = new StudentModel()
                    {
                        ID = reader.GetInt32(reader.GetOrdinal("Id")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        DoB = reader.GetString(reader.GetOrdinal("DoB")),
                        CGPA = reader.GetInt32(reader.GetOrdinal("CGPA")),
                        Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                        DepID = reader.GetInt32(reader.GetOrdinal("DepID")),
                    };
                    StudentModel.Add(s);
                }
                conn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return StudentModel;
        }
        public StudentModel Get(int id)
        {
            StudentModel s = null;
            string query = $"select * from Products Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    s = new StudentModel()
                    {
                        ID = reader.GetInt32(reader.GetOrdinal("Id")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        DoB = reader.GetString(reader.GetOrdinal("DoB")),
                        CGPA = reader.GetInt32(reader.GetOrdinal("CGPA")),
                        Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                        DepID = reader.GetInt32(reader.GetOrdinal("DepID")),
                    };
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            conn.Close();
            return s;
        }
        public void Edit(StudentModel s)
        {
            string query = $"Update Student Set Name='{s.Name}', CGPA={s.CGPA} ,DoB={s.DoB}, Credit='{s.Credit},DepID='{s.DepID}' Where Id = {s.ID}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(StudentModel s)
        {

        }
    }
}