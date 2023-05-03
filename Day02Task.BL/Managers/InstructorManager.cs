using Day02Task.BL.DTO;
using Day02Task.DAL.Data;
using Day02Task.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02Task.BL.Managers
{
    public class InstructorManager : IInstructorManager
    {
        public IInstructorRep InstructorRep { get; }

        public InstructorManager(IInstructorRep instructorRep)
        {
            InstructorRep = instructorRep;
        }

        public IEnumerable<InstructorDTO> GetAll()
        {
            var Ins = InstructorRep.GetAll();
            List<InstructorDTO> instructors = new List<InstructorDTO>();
            foreach (var item in Ins)
            {
                InstructorDTO str = new InstructorDTO()
                {
                    InstructorId = item.Id,
                    Age = item.Age,
                    Address = item.Address,
                    Email = item.Email,
                    InstructorName = item.Name,
                    DepartmentId=item?.DeptId
                    
                };
                instructors.Add(str);
            }

            return instructors;
        }

        public InstructorDTO GetDetails(int id)
        {

            InstructorDTO st = new InstructorDTO();
            var insEntity = InstructorRep.GetDetails(id);
            if (insEntity != null)
            {
                st.InstructorId = insEntity.Id;
                st.Age = insEntity.Age;
                st.Address = insEntity.Address;
                st.Email = insEntity.Email;
                st.InstructorName = insEntity.Name;
                st.DepartmentName = insEntity.department.Name;
                st.DepartmentId = insEntity.DeptId;
            }

            return st;
        }

        public void InsertInstructor(InstructorDTO ins)
        {
            Instructor st = new Instructor();

            st.Name = ins.InstructorName;
            st.Age = ins.Age;
            st.Address = ins.Address;
            st.Email = ins.Email;
            st.Id = ins.InstructorId;
            st.DeptId = ins.DepartmentId;
            
            
            InstructorRep.InsertInstructor(st);

        }

        public void UpdateInstructor(int id, InstructorDTO ins)
        {
            Instructor st = InstructorRep.GetDetails(id);

            st.Name = ins.InstructorName;
            st.Age = ins.Age;
            st.Address = ins.Address;
            st.Email = ins.Email;
            st.Id = ins.InstructorId;
            st.DeptId = ins.DepartmentId;

            InstructorRep.UpdateInstructor(id, st);


        }

        public void DeleteInstructor(int id)
        {
            //InstructorDTO sd= InstructorRep.GetDetails(id); ;

            InstructorRep.DeleteInstructor(id);

        }



    }
}
