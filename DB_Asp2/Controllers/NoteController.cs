using DB_Asp2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; 

namespace DB_Asp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        private readonly Mydbcontext _dbcontext;

        public NoteController(Mydbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpPost]
        public IActionResult Post(Note note)
        {
            _dbcontext.Notes.Add(note);
            _dbcontext.SaveChanges();
            return Ok();
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_dbcontext.Notes);
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            Note note = _dbcontext.Notes.ToList().Find(item => item.Id == id);
            if(note == null)
            {
                return BadRequest();
            }
            _dbcontext.Notes.Remove(note);
            _dbcontext.SaveChanges();
            return Ok();
        }
    }
}
