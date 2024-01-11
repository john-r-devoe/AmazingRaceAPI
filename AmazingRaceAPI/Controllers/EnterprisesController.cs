using Microsoft.AspNetCore.Mvc;
using AmazingRaceAPI.Data;
using AmazingRaceAPI.Entitites;
using AmazingRaceAPI.DTOS;

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
            try
            {
                return _repo.GetEnterprises();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{enterpriseId}")]
        public ActionResult<Enterprise> GetEnterprise(int enterpriseId)
        {
            try
            {
                return _repo.GetEnterprise(enterpriseId);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPatch]
        [Route("{enterpriseId}")]
        public ActionResult EditEnterprise(int enterpriseId, EnterpriseDTO newObject)
        {
            try
            {
                return Ok(_repo.EditEnterprise(enterpriseId, newObject));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult AddEnterprise(EnterpriseDTO newObject)
        {
            try
            {
                return Ok(_repo.AddEnterprise(newObject));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{enterpriseId}")]
        public ActionResult DeleteEnterprise(int enterpriseId)
        {
            try
            {
                return Ok(_repo.DeleteEnterprise(enterpriseId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
