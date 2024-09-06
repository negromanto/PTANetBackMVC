using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_MVC_ASR.Models
{
    public class Feed
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Timestamp { get; set; }
        public string? TimestampUTC { get; set; }
        public string? Country { get; set; }
        public decimal? ImbalanceFee { get; set; }
        public decimal? HourlyImbalanceFee { get; set; }
        public decimal? PeakLoadFee { get; set; }
        public decimal? VolumeFee { get; set; }
        public int WeeklyFee { get; set; }
    }
}
