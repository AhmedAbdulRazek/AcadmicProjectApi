using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Day02Task.DAL.Data
{

    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Location { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Branche { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Description { get; set; }

        //[JsonIgnore]
        public virtual List<Instructor> Instructors { get; set; } = new List<Instructor>();

    }
}
