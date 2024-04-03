using Microsoft.EntityFrameworkCore;

namespace HotelLeries.Models.HotellerieModel
{
    public class HotellerieDbContext: DbContext
    {
        public HotellerieDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Hotel> Hotels { get; set; } = null!;
    }
}
