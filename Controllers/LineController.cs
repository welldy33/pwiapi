using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pwiapi.Data;
using pwiapi.Models;
using AutoMapper;
using pwiapi.Dtos;
using Microsoft.AspNetCore.JsonPatch;

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

        [HttpGet("{lineno}",Name = "GetLineByNo")]
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
            _repository.SaveChanges();

            var lineReadDto = _mapper.Map<LineReadDtos>(lineModel);
            //return Ok(lineReadDto);
            return CreatedAtRoute(nameof(GetLineByNo),new {lineno=lineReadDto.LINE_NO}, lineReadDto); 
         }

        [HttpPut("{lineno}")]
        public ActionResult UpdateLine(string lineno, LineUpdateDtos cud) {
            Line lineModelFromRepo = _repository.GetLineByNo(lineno);
            if (lineModelFromRepo == null) {
                return NotFound();
            }

            _mapper.Map(cud, lineModelFromRepo);
            _repository.UpdateLine(lineModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

        //PATCH API
        [HttpPatch("{lineno}")]
        public ActionResult PartialCommandUpdate(string lineno, JsonPatchDocument<LineUpdateDtos> patchDoc) {
            Line lineModelFromRepo = _repository.GetLineByNo(lineno);
            if (lineModelFromRepo == null)
            {
                return NotFound();
            }
            var lineToPatch = _mapper.Map<LineUpdateDtos>(lineModelFromRepo);
            patchDoc.ApplyTo(lineToPatch, ModelState);
            if (!TryValidateModel(lineToPatch)) {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(lineToPatch, lineModelFromRepo);
            _repository.UpdateLine(lineModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

        //Delete
        [HttpDelete("{lineno}")]
        public ActionResult DeleteLine(string lineno) {
            Line lineModelFromRepo = _repository.GetLineByNo(lineno);
            if (lineModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteLine(lineModelFromRepo);
            _repository.SaveChanges();
            return Ok();
        }

    }
}
