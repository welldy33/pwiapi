using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pwiapi.Data;
using pwiapi.Models;

namespace pwiapi.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class EmpController : ControllerBase
    {

        [HttpGet]
        //public ActionResult<IEnumerable<Line>> GetAllLines() {
        public ActionResult GetAllLines()
        {
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            // LINQ Query 
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;
            return Ok(myLinqQuery);
        }
    }

    [Route("api/dev")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAllLines()
        {
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            // LINQ Query 
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;
            return Ok(myLinqQuery);
        }
    }
}
