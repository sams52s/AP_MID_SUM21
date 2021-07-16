using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DepartmentService
    {
        public static List<string> GetDepartementNames()
        {
            return DepartmentService.GetDepartementNames();
        }
        public static List<DepartmentModel> GetDepartments()
        {
            var departments = DepartmentRepo.GetDepartments();
            List<DepartmentModel> data = new List<DepartmentModel>();
            foreach (var d in departments)
            {
                var dm = new DepartmentModel()
                {
                    Id = d.Id,
                    Name = d.Name
                };
                data.Add(dm);
           
            }
            return data;
        }
        public static void AddDepartment(DepartmentModel dept)
        {
            var d = new Department() { Id = dept.Id, Name = dept.Name };
            DepartmentRepo.AddDepartment(d);
        }
    }
}
