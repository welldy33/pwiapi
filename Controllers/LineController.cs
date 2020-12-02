using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pwiapi.Data;
using pwiapi.Models;

namespace pwiapi.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class LineController : ControllerBase
    {
        private readonly ILineRepo _repository;

        public LineController(ILineRepo repository) {
            _repository = repository;
        }
        //private readonly MockLineRepo _repository = new MockLineRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Line>> GetAllLines() {
            var lineItems = _repository.GetLines();
            return Ok(lineItems);
        }

        [HttpGet("{lineno}")]
        public ActionResult<Line> GetLineByNo(string lineno) {
            var lineItem = _repository.GetLineByNo(lineno);
            return Ok(lineItem);
        }
    }
}
