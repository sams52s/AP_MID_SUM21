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
        public List<string> GetNames()
        {
            return DepartmentService.GetDepartmentNames();
        }
        [Route("api/Department/GetAll")]
        [HttpGet]
        public List<DepartmentModel>GetAllDepartments()
        {
            return DepartmentService.GerDepartmenrs();
        }
        [Route("api/Department/Add")]
        [HttpPost]
        public void Add(DepartmentModel dept)
        {
            DepartmentService.AddDepartment(dept);
        }
    }
}
