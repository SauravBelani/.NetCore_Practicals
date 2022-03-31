using Practical_17.Contracts;
using Practical_17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_17.Repository
{
    public class StudentRepository:GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
