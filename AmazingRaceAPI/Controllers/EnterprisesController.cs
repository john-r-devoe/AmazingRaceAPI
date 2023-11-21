//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
using AmazingRaceAPI.Data;
using AmazingRaceAPI.Entitites;

namespace AmazingRaceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnterprisesController : ControllerBase
    {
        private readonly IEnterpriseRepository _repo;

        public EnterprisesController(IEnterpriseRepository repo)
        {
            _repo = repo;
        }

        // GET: api/Enterprises
        [HttpGet]
        public ActionResult<IEnumerable<Enterprise>> GetEnterprises()
        {
            return _repo.GetEnterprises();
        }

    }
}
