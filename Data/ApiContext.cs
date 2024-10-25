using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelBookingAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace HotelBookingAPI.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<HotelBooking> Bookings { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            :base(options)
            {
                
            }
    }
}