using computer.Shared.Entities;
using computerClinic.Backend.Date;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace computerClinic.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CenterComputersController : ControllerBase
    {
        private readonly DataContext _context;

        public CenterComputersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(_context.MyComputers.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var computer=_context.MyComputers.FirstOrDefault(x => x.Id == id);
            if (computer == null)
            {
                return NotFound();
            }
            return Ok(computer);
        }


        [HttpPost]
        public IActionResult Post(CenterComputer computer)
        {
            _context.Add(computer);
            _context.SaveChanges();
            return Ok (computer);
        }


        [HttpPut]
        public IActionResult Put(CenterComputer computer)
        {
            var Mycomputer = _context.MyComputers.FirstOrDefault(x => x.Id == computer.Id);
            if (computer == null)
            {
                return NotFound();
            }
            computer.Description = Mycomputer.Description;
            computer.Date = Mycomputer.Date;
            computer.IsCompleted = Mycomputer.IsCompleted;
           
            _context.Update(computer);
            _context.SaveChanges();
            return Ok (computer);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int Id)
        {
            var Mycomputer = _context.MyComputers.FirstOrDefault(x => x.Id == Id);
            if (Mycomputer == null)
            {
                return NotFound();
            }
            _context.Remove(Mycomputer);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
