using ApiCoreAngular.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCoreAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserFormDetailsController : ControllerBase
    {
        private readonly UserFormContext _userFormContext;

        public UserFormDetailsController(UserFormContext userFormContext)
        {
            _userFormContext = userFormContext;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            return  Ok(_userFormContext.UserFormDetails.AsNoTracking().ToList().ToString());
        }

        [HttpPost("adduser")]
        public async Task<IActionResult> AddUser([FromBody] UserFormDetail userFormDetail)
        {
            _userFormContext.UserFormDetails.Add(userFormDetail);
            await _userFormContext.SaveChangesAsync();
            return Ok(userFormDetail.Id);
        }
    }
}
