namespace WebAPI_MVC_ASR.Models.DTOs
{
    public class FeedDTO
    {
        public string? Timestamp { get; set; }
        public string? TimestampUTC { get; set; }
        public string? Country { get; set; }
        public double? ImbalanceFee { get; set; }
        public double? HourlyImbalanceFee { get; set; }
        public double? PeakLoadFee { get; set; }
        public double? VolumeFee { get; set; }
        public int WeeklyFee { get; set; }
    }
}
