using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _4_tier_web_api.Controllers
{
    public class DepartmentController : ApiController
    {
        [Route("api/Department/Names")]
        [HttpGet]
        public List<string>GetNames()
        {
            return DepartmentService.GetDepartementNames();
        }
        [Route("api/Department/GetAll")]
        [HttpGet]
        public List<DepartmentModel>GetAllDepartments() {

            return DepartmentService.GetDepartments();
        }
        [Route("api/Department/Add")]
        [HttpPost]
        public void add(DepartmentModel dept)
        {
            DepartmentService.AddDepartment(dept);
        }
    }
}
