using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02Task.DAL.Data
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SSN { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Address { get; set; }
        public int? Age { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public decimal? Salary { get; set; }


        [Required, DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [ForeignKey("department")]
        public int? DeptId { get; set; }

        //[JsonIgnore]
        public virtual Department? department { get; set; }


    }
}
