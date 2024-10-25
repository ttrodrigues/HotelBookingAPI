using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBookingAPI.Models
{
    public class HotelBooking
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public string? ClientName { get; set; }
    }
}