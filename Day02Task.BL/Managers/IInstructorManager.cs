using Day02Task.BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02Task.BL.Managers
{
    public interface IInstructorManager
    {

        public IEnumerable<InstructorDTO> GetAll();
        public InstructorDTO GetDetails(int id);
        public void InsertInstructor(InstructorDTO ins);
        public void UpdateInstructor(int id, InstructorDTO ins);
        public void DeleteInstructor(int id);


    }
}
