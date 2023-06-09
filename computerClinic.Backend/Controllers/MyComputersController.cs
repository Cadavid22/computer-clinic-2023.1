using computer.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace computerClinic.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyComputersController : ControllerBase
    {
        private List<MyComputer> _myComputers;

        public MyComputersController()
        {
            _myComputers = new List<MyComputer>
            {

            };
        }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(_myComputers);
        }


        [HttpPost]
        public IActionResult Post(MyComputer mycomputers)
        {
            _myComputers.Add(mycomputers);
            return Ok(mycomputers);
        }


        [HttpPut]
        public IActionResult Put(MyComputer mycomputers)
        {
            var computer = _myComputers.FirstOrDefault(t => t.Id == mycomputers.Id);
            if (computer == null) 
            {
                return NotFound();
            }
            computer.Description = mycomputers.Description;
            computer.Date =mycomputers.Date;
            computer.IsCompleted = mycomputers.IsCompleted;

            return Ok(computer);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            var computer = _myComputers.FirstOrDefault(t => t.Id == Id);
            if (computer == null)
            {
                return NotFound();
            }
            _myComputers.Remove(computer);
            return NoContent();
        }

    }
}
