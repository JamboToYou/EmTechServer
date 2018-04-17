using System;
using System.ComponentModel.DataAnnotations;

namespace EmTechServer.Data.Models
{
    public class Invitation
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public City City { get; set; }
        public string InviteKey { get; set; }
        [Timestamp]
        public DateTime Date { get; set; }
    }
}