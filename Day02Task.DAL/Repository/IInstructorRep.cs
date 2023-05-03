using Day02Task.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02Task.DAL.Repository
{
    public interface IInstructorRep
    {

        public IEnumerable<Instructor> GetAll();
        public Instructor GetDetails(int id);
        public void InsertInstructor(Instructor ins);
        public void UpdateInstructor(int id, Instructor ins);
        public void DeleteInstructor(int id);

    }
}
