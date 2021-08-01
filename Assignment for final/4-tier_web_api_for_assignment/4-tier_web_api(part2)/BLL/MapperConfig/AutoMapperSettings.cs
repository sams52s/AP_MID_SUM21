using AutoMapper;
using DAL;
using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {

        public AutoMapperSettings()
        {
            CreateMap<Department, DepartmentModel>();
            CreateMap<Department, DeparmentDetail>();
            CreateMap<Student, StudentModel>();
            CreateMap<StudentModel, Student>().ForMember(e => e.Department, sm => sm.Ignore());
        }
    }
}
