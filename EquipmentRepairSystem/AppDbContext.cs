using Microsoft.EntityFrameworkCore;

namespace EquipmentRepairSystem
{
    public class AppDbContext : DbContext
    {
        public  AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        //Ticket資料表
        public DbSet<Ticket> Tickets { get; set; }
    }
}
