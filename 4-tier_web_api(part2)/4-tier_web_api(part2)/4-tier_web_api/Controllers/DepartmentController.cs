using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace _4_tier_web_api.Controllers
{
    //[EnableCorsAttribute("www.aiub.edu","*","GET")] example
    public class DepartmentController : ApiController
    {
        //[EnableCorsAttribute("www.NSU.edu","*","GET")] example
        [Route("api/Department/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return DepartmentService.GetDepartmentNames();
        }
        //[EnableCorsAttribute("www.AIUB.edu,www.Facebook.com","*","GET")] example
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
        [Route("api/Department/All/Details")]
        public List<DeparmentDetail> GetDepartmentWithDetails() {
            return DepartmentService.GetDepartmentWithDetails();
        }
        [Route ("api/Department/{id}/Details")]
        public DeparmentDetail GetDeparmentDetail (int id)
        {
            return DepartmentService.GetDepartmentDetail(id);
        }
    }
}
