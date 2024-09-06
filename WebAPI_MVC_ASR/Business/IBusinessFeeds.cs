using WebAPI_MVC_ASR.Models;
using WebAPI_MVC_ASR.Models.DTOs;

namespace WebAPI_MVC_ASR.Business
{
    public interface IBusinessFeeds
    {
        Task<IEnumerable<FeedDTO>> GetAll();
        Task<FeedDTO?> GetOne(int id);
    }
}