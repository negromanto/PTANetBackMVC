using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebAPI_MVC_ASR.Business;
using WebAPI_MVC_ASR.Models;
using WebAPI_MVC_ASR.Models.DTOs;

namespace WebAPI_MVC_ASR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedController : ControllerBase
    {
        private readonly ILogger<FeedController> _logger;
        private readonly IBusinessFeeds businessFeeds;
        public APIResponse _response;

        public FeedController(ILogger<FeedController> logger, IBusinessFeeds businessFeeds)
        {
            _logger = logger;
            this.businessFeeds = businessFeeds;
            _response = new APIResponse();

        }

        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetAll()
        {
            try
            {
                _logger.LogInformation("Se obtienen todas FEEDs");

                _response.result = await businessFeeds.GetAll();
                _response.statusCode = HttpStatusCode.OK;

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Error al consultar todas FEEDs");
                _response.Success = false;
                _response.errorMessages = new List<string> { ex.ToString() };
            }

            return _response;
        }


        [HttpGet("id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetOne(int id)
        {
            try
            {
                if (id == 0)
                {
                    _logger.LogError($"Se consulta un FEED por id:{id} pero este no es un valor valido");
                    _response.Success = false;
                    _response.statusCode = HttpStatusCode.BadRequest;
                    
                    return BadRequest(_response);
                }

                var feed = await businessFeeds.GetOne(id);

                // En caso de no encontrarlo
                if (feed == null)
                {
                    _logger.LogError($"Se consulta un FEED por id:{id} pero este no fue encontrado");
                    _response.statusCode = HttpStatusCode.NotFound;
                    _response.Success = false;
                    return NotFound(_response);
                }

                _logger.LogInformation($"Se obtiene un FEED por id:{id}");

                _response.statusCode= HttpStatusCode.OK;
                _response.result = feed;

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Error al consultar por id:{id}");
                _response.Success = false;
                _response.errorMessages = new List<string> { ex.ToString() };
            }

            return _response;
        }
    }
}
