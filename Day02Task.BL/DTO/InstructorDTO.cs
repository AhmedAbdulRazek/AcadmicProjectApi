using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02Task.BL.DTO
{
    public class InstructorDTO
    {

        public int InstructorId { get; set; }
        public string? InstructorName { get; set; }
        public int? Age { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? DepartmentName { get; set; }

        public int? DepartmentId { get; set; }

    }
}
