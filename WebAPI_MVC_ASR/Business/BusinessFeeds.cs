using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebAPI_MVC_ASR.Datos;
using WebAPI_MVC_ASR.Models;
using WebAPI_MVC_ASR.Models.DTOs;
using WebAPI_MVC_ASR.Repository.IRepository;

namespace WebAPI_MVC_ASR.Business
{
    public class BusinessFeeds : IBusinessFeeds
    {
        private readonly ILogger<BusinessFeeds> logger;
        private readonly IFeedRepository feedRepository;
        //private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public BusinessFeeds(ILogger<BusinessFeeds> logger, IFeedRepository feedRepository, IMapper mapper) 
        {
            this.logger = logger;
            this.feedRepository = feedRepository;
            this.mapper = mapper;

        }

        /// <summary>
        /// Retorna todos los registros para Feed
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<FeedDTO>> GetAll()
        {
            logger.LogInformation("Bussiness: solicitud todos los Feeds");
            List<Feed> feeds;

            feeds = await feedRepository.GetAllAsync();

            return mapper.Map<IEnumerable<FeedDTO>>(feeds);
        }

        /// <summary>
        /// Consulta un único registro por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<FeedDTO?> GetOne(int id)
        {
            logger.LogInformation($"Bussiness: consulta el registro con id: {id}");

            Feed? feed = await feedRepository.GetAsync(x => x.Id == id);

            return mapper.Map<FeedDTO>(feed);
        }
    }
}
