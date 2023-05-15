using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppAssignment
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start time is required")]
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public Recurring_task IsRecurring { get; set; }
        public bool IsFinished { get; set; }
        public int TaskTypeId { get; set; }
        public TaskType TaskType { get; set; }

    }
}