using EmDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmpServConnToSSMS3.Controllers
{
    public class EmployeesController : ApiController
    {
        // GET: api/Employees
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        public IEnumerable<Employee> Get()
        {
            using (EmEntities ent = new EmEntities())
            {
                return ent.Employees.ToList();
            }
        }




        // GET: api/Employees/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employees
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employees/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employees/5
        public void Delete(int id)
        {
        }
    }
}
