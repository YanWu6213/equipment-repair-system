using System.ComponentModel.DataAnnotations;

namespace EquipmentRepairSystem.DTOs
{
    public class TicketCreateDto
    {
        [Required(ErrorMessage = "報修內容不可以空")]
        [StringLength(100, ErrorMessage = "內容不可以超過100字")]
        public string Description { get; set; }

        [Required]
        [RegularExpression("待處理|維修中|已完成", ErrorMessage = "狀態只能是：待處理、維修中、已完成")]
        public string Status { get; set; }

        public string RepairerName { get; set; }
    }
}
