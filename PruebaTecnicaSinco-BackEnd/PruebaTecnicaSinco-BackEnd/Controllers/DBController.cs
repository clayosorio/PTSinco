using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PruebaTecnicaSinco_BackEnd.Context;

namespace PruebaTecnicaSinco_BackEnd.Controllers
{
	[ApiController]
	[Route("api/[controller]/[action]")]
	public class DBController : ControllerBase
	{
		PTContext _ptContext;
		public DBController(PTContext ptContext)
        {
			_ptContext = ptContext;
		}

        [HttpGet]
		[Route("createdb")]
		public IActionResult CreateDatabase()
		{
			_ptContext.Database.EnsureCreated();
			return Ok();
		}
	}
}
