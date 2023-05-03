using Day02Task.DAL.Context;
using Day02Task.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Day02Task.DAL.Repository
{
    public class InstructorRep : IInstructorRep
    {

        public CompanyContext Context { get; }

        public InstructorRep(CompanyContext context)
        {
            Context = context;
        }
   

        public IEnumerable<Instructor> GetAll()
        {
            return Context.Instructors.Include(d => d.department).ToList();
        }

        public Instructor GetDetails(int id)
        {
            return Context.Instructors.Include(d => d.department).FirstOrDefault(i => i.Id == id);
        }

        public void InsertInstructor(Instructor ins)
        {
            Context.Instructors.Add(ins);
            Context.SaveChanges();
        }

        public void UpdateInstructor(int id, Instructor ins)
        {
            Instructor oldIns = Context.Instructors.Find(id);


            oldIns.Name = ins.Name;
            oldIns.SSN = ins.SSN;
            oldIns.Address = ins.Address;
            oldIns.Age = ins.Age;
            oldIns.Salary = ins.Salary;
            oldIns.Password = ins.Password;
            oldIns.Phone = ins.Phone;
            oldIns.DOB = ins.DOB;
            oldIns.DeptId = ins.DeptId;

            Context.SaveChanges();



        }

        public void DeleteInstructor(int id)
        {
            Context.Remove(Context.Instructors.Find(id));
            Context.SaveChanges();
        }

    }
}
