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

        [HttpGet("all")]
        public List<Ticket> GetAllTickets()
        {
            List<Ticket> tickets = new List<Ticket>
            {
                new Ticket { Id = 1, Description = "冷氣壞了", Status = "待處理", RepairerName = "王小明" },
                new Ticket { Id = 2, Description = "電腦無法開機", Status = "已處理", RepairerName = "李小華" }
            };
            return tickets;
        }

        [HttpGet("search")]
        public List<Ticket> SearchTickets(string name)
        {
            List<Ticket> allTickets = new List<Ticket>
               {
                   new Ticket { Id = 1, Description = "冷氣壞了", Status = "待處理", RepairerName = "王小明" },
                   new Ticket { Id = 2, Description = "電腦無法開機", Status = "已處理", RepairerName = "李小華" }
               };
            var result = allTickets.Where(t => t.RepairerName.Contains(name)).ToList();

            return result;
        }
    }
}
