using entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Sample_Postgre.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public class StudentController : ControllerBase
    {
        //Declaration
        private readonly LearningContext _learningContext;

        //Constructor
        public StudentController(LearningContext context)
        {
            _learningContext = context;
        }
        [HttpGet]
        public async Task<List<Student>> GetList()
        {
           return await _learningContext.Students.ToListAsync(); 
        }
        
    }
}
