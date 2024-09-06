﻿using System.ComponentModel.DataAnnotations;
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
        public double? ImbalanceFee { get; set; }
        public double? HourlyImbalanceFee { get; set; }
        public double? PeakLoadFee { get; set; }
        public double? VolumeFee { get; set; }
        public int WeeklyFee { get; set; }
    }
}
