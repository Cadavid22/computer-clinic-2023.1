using computer.Shared.Entities;
using computerClinic.Backend.Date;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace computerClinic.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyComputersController : ControllerBase
    {
        private readonly DataContext _context;

        public MyComputersController(DataContext context)
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
        public IActionResult Post(MyComputer mycomputers)
        {
            _context.Add(mycomputers);
            _context.SaveChanges();
            return Ok (MyComputer);
        }


        [HttpPut]
        public IActionResult Put(MyComputer mycomputers)
        {
            var computer = _context.MyComputers.FirstOrDefault(x => x.Id == MyComputer.Id);
            if (computer == null)
            {
                return NotFound();
            }
            computer.Description = MyComputer.Description;
            computer.Date = MyComputer.Date;
            computer.IsCompleted = MyComputer.IsCompleted;
            computer.Description = MyComputer.Description;
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int Id)
        {
           
            return NoContent();
        }

    }
}
