using System.ComponentModel;

namespace WebAPI_MVC_ASR.Models.DTOs
{
    public class FeedDTO
    {
        /// <summary>
        /// Identificador unico para el feed
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Fecha y hora del evento
        /// </summary>
        public string? Timestamp { get; set; }
        /// <summary>
        /// Fecha y hora del evento (UTC)
        /// </summary>
        public string? TimestampUTC { get; set; }
        /// <summary>
        /// Pais de origen
        /// </summary>
        public string? Country { get; set; }
        public decimal? ImbalanceFee { get; set; }
        public decimal? HourlyImbalanceFee { get; set; }
        public decimal? PeakLoadFee { get; set; }
        public decimal? VolumeFee { get; set; }
        public int WeeklyFee { get; set; }
    }
}
