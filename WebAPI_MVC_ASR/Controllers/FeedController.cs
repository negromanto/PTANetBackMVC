using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_MVC_ASR.Business;
using WebAPI_MVC_ASR.Models.DTOs;

namespace WebAPI_MVC_ASR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedController : ControllerBase
    {
        private readonly ILogger<FeedController> _logger;
        private readonly IBusinessFeeds businessFeeds;

        public FeedController(ILogger<FeedController> logger, IBusinessFeeds businessFeeds)
        {
            _logger = logger;
            this.businessFeeds = businessFeeds;

        }

        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<FeedDTO>>> GetAll()
        {
            _logger.LogInformation("Se obtienen todas FEEDs");

            var feeds = await businessFeeds.GetAll();

            return Ok(feeds);
        }


        [HttpGet("id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FeedDTO>> GetOne(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Se consulta un FEED por id:{id} pero este no es un valor valido");
                return BadRequest();
            }

            var feed = await businessFeeds.GetOne(id);

            // En caso de no encontrarlo
            if (feed == null)
            {
                _logger.LogError($"Se consulta un FEED por id:{id} pero este no fue encontrado");
                return NotFound();
            }

            _logger.LogInformation($"Se obtiene un FEED por id:{id}");
            return Ok(feed);
        }
    }
}
