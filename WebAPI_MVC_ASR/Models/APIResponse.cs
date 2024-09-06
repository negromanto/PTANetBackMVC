using System.Net;

namespace WebAPI_MVC_ASR.Models
{
    public class APIResponse
    {
        public HttpStatusCode statusCode { get; set; }
        public bool Success { get; set; } = true;
        public List<string> errorMessages { get; set; } = new List<string>();
        public object result { get; set; } = new object();
    }
}
