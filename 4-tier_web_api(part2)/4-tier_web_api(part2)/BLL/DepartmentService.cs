﻿using BEL;
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
        static DepartmentService()
        {
            AutoMapper.Mapper.Initialize(config => config.AddProfile<MapperConfig.AutoMapperSettings>());
        }
        public static List<string> GetDepartmentNames()
        {
            return DepartmentRepo.GetDepartmentNames();
            
        }
        public static List<DepartmentModel> GerDepartmenrs()
        {
            var departments = DepartmentRepo.GetDepartments();
            var data = AutoMapper.Mapper.Map<List<Department>, List<DepartmentModel>>(departments);
            /*List<DepartmentModel> data = new List<DepartmentModel>();
            foreach(var d in departments) {
                var dm = new DepartmentModel()
                {
                    Id = d.Id,
                    Name = d.Name
                };
                data.Add(dm);
            }*/
            return data;
        }
        public static void AddDepartment(DepartmentModel dept)
        {
            var d = AutoMapper.Mapper.Map<DepartmentModel, Department>(dept);
           /* var d = new Department()
            {
                Id = dept.Id,
                Name = dept.Name
            };*/
            DepartmentRepo.AddDepartment(d);
        }

        public static DeparmentDetail GetDepartmentDetail(int id)
        {
            var d = DepartmentRepo.GetDepartmentDetail(id);
            var deptdetail = AutoMapper.Mapper.Map<Department, DeparmentDetail>(d);
            return deptdetail;
        }

        public static List<DeparmentDetail> GetDepartmentWithDetails()
        {
            var data = DepartmentRepo.GetDepartments();
            var dDetails = AutoMapper.Mapper.Map<List<Department>,List<DeparmentDetail>>(data);
            return dDetails;
        }

    }
}
