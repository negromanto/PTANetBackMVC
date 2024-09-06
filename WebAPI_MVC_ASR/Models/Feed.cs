using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_MVC_ASR.Models
{
    public class Feed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public DateTimeOffset TimestampUTC { get; set; }
        public string? Country { get; set; }
        public float? ImbalanceFee { get; set; }
        public float? HourlyImbalanceFee { get; set; }
        public float? PeakLoadFee { get; set; }
        public float? VolumeFee { get; set; }
        public int WeeklyFee { get; set; }
    }
}
