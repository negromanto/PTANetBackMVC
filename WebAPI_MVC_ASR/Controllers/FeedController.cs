using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_MVC_ASR.Models.DTOs;

namespace WebAPI_MVC_ASR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedController : ControllerBase
    {
        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<FeedDTO>> GetAll()
        {
            return Ok(new FeedDTO[0]);
        }


        [HttpGet("id:int")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<FeedDTO> GetOne(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            //En caso de no encontrarlo
            //return NotFound();

            return Ok(new FeedDTO());
        }
    }
}
