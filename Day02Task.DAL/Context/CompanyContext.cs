using Day02Task.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02Task.DAL.Context
{
    public class CompanyContext : DbContext
    {

        public CompanyContext(DbContextOptions<CompanyContext> opt):base(opt)
        {

        }


        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
