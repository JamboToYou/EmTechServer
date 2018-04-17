using System;
using System.ComponentModel.DataAnnotations;

namespace EmTechServer.Data.Models
{
    public class Broadcast
    {
        [Key]
        public int Id { get; set; }
        public string UniqueId { get; set; }
        public int BusId { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public float Rating { get; set; }
        public int Rating_count { get; set; }
        public int Prev_station { get; set; }
        public int Next_station { get; set; }
        public int Direction { get; set; }
        [Timestamp]
        public DateTime UpdTime { get; set; }
    }
}