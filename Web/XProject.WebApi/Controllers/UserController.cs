using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;
using XProject.Contract.Repository.Models;
using XProject.Repository.Infrastructure;


namespace XProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("Login")]
        public IActionResult Validate(Login login)
        {
            var user = _context.users.SingleOrDefault(p => p.Name == model.Name && model.Password == p.Password);
        }
    }
}
