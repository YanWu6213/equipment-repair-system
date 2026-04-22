using Microsoft.AspNetCore.Mvc;

namespace EquipmentRepairSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketsController : ControllerBase
    {
        
        [HttpGet]
        public Ticket GetFakeTicket()
        {
            return new Ticket
            {
                Id = 1,
                Description = "冷氣壞了",
                Status = "待處理",
                RepairerName = "王小明"
            };
        }
    }
}
