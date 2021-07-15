using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentRepo
    {
        static StudentMSEntities context;
        static DepartmentRepo()
        {
            context = new StudentMSEntities();
        }
        public static List<string> GetDepartmentNames()
        {
            var data = context.Departments.Select(e => e.Name).ToList();
            return data;
        }
    }
}
