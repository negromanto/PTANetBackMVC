using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_MVC_ASR.Models.DTOs;

namespace WebAPI_MVC_ASR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedController : ControllerBase
    {
        private readonly ILogger<FeedController> _logger;

        public FeedController(ILogger<FeedController> logger)
        {
            _logger = logger;

        }

        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<FeedDTO>> GetAll()
        {
            _logger.LogInformation("Se obtienen todas FEEDs");


            return Ok();
        }


        [HttpGet("id:int")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<FeedDTO> GetOne(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Se consulta un FEED por id:{id} pero este no es un valor valido");
                return BadRequest();
            }

            //En caso de no encontrarlo
            //_logger.LogError($"Se consulta un FEED por id:{id} pero este no fue encontrado");
            //return NotFound();

            _logger.LogInformation($"Se obtiene un FEED por id:{id}");
            return Ok(new FeedDTO());
        }
    }
}
