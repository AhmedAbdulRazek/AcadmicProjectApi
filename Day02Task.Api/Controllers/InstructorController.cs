using Day02Task.BL.DTO;
using Day02Task.BL.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day02Task.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {

        public IInstructorManager InstructorManager { get; }

        public InstructorController(IInstructorManager instructorManager)
        {
            InstructorManager = instructorManager;
        }



        [HttpGet]
        public ActionResult GetAll()
        {
            List<InstructorDTO> inst = InstructorManager.GetAll().ToList();
            if (inst.Count > 0)
            {
                return Ok(inst);
            }
            return BadRequest();
        }
        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(InstructorManager.GetDetails(Id));
        }


        [HttpPost]
        public ActionResult Post(InstructorDTO instructor)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    InstructorManager.InsertInstructor(instructor);
                    return Created("url", instructor);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return BadRequest();
        }

        [HttpPut]
        public ActionResult Edit(int id, InstructorDTO instructor)
        {
            try
            {

                if (id != instructor.InstructorId)
                {
                    return BadRequest();
                }

                if (instructor == null)
                {
                    return NotFound();
                }


                if (ModelState.IsValid)
                {
                    InstructorManager.UpdateInstructor(id, instructor);
                    return Ok(instructor);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return BadRequest();
        }



        [HttpDelete]
        public ActionResult DeleteIns(int id)
        {
            InstructorManager.DeleteInstructor(id);
            return Ok();
        }




    }
}
