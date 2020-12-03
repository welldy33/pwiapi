using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pwiapi.Data;
using pwiapi.Models;
using AutoMapper;
using pwiapi.Dtos;

namespace pwiapi.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class LineController : ControllerBase
    {
        private readonly ILineRepo _repository;
        private readonly IMapper _mapper;

        public LineController(ILineRepo repository,IMapper mapper) {
            _repository = repository;
            _mapper = mapper;
        }
        //private readonly MockLineRepo _repository = new MockLineRepo();

        [HttpGet]
        //public ActionResult<IEnumerable<Line>> GetAllLines() {
        public ActionResult<IEnumerable<LineReadDtos>> GetAllLines()
        {
            var lineItems = _repository.GetLines();
            //return Ok(lineItems);
            return Ok(_mapper.Map<IEnumerable<LineReadDtos>>(lineItems));
        }

        [HttpGet("{lineno}")]
        //public ActionResult<Line> GetLineByNo(string lineno)
        //{
         public ActionResult<LineReadDtos> GetLineByNo(string lineno) {
            var lineItem = _repository.GetLineByNo(lineno);
            if (lineItem != null)
            {
                // return Ok(lineItem);
                return Ok(_mapper.Map<LineReadDtos>(lineItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<LineReadDtos> CreateLine(LineCreateDtos lcd) {
            var lineModel = _mapper.Map<Line>(lcd);
            _repository.CreateLine(lineModel);
            return Ok(lineModel);
        }
    }
}
