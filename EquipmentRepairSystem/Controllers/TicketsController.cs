using EquipmentRepairSystem.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;    

namespace EquipmentRepairSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketsController : ControllerBase
    {
        private readonly AppDbContext _context;
        //建構子注入AppDbContext
        public TicketsController(AppDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        // 查詢所有的Ticket
        public async Task<ActionResult<IEnumerable<Ticket>>> GetAllTickets()
        {
            return await _context.Tickets.ToListAsync();
        }

        //[HttpPost]
        //// 創建新的Ticket
        //public async Task<ActionResult<Ticket>> CreateTicket(Ticket ticket)
        //{
        //    _context.Tickets.Add(ticket);
        //    await _context.SaveChangesAsync(); // 這行才會真正寫進硬碟
        //    return ticket;
        //}

        [HttpPost]
        public async Task<ActionResult<Ticket>> CreateTicket(TicketCreateDto dto)
        {
            var ticket = new Ticket
            {
                Description = dto.Description,
                Status = dto.Status,
                RepairerName = dto.RepairerName
            };

            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync(); // 這行才會真正寫進硬碟
            return ticket;
        }


        [HttpGet("{id}")]
        // 根據ID查詢特定的Ticket
        public async Task<ActionResult<Ticket>> GetTicketById(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }
            return ticket;
        }

        [HttpDelete("{id}")]
        // 根據ID刪除特定的Ticket
        public async Task<IActionResult> DeleteTicket(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }
            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPut("{id}")]
        // 根據ID更新特定的Ticket
        public async Task<IActionResult> UpdateTicket(int id, Ticket ticket)
        {
            if (id != ticket.Id)
            {
                return BadRequest();
            }
            _context.Entry(ticket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Tickets.Any(e => e.Id == id)) return NotFound();
                else throw;
            }

            return NoContent();
        }

    }
}
