using Practical_16.Contracts;
using Practical_16.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_16.Repositories
{
    public class StudentRepository: GenericRepository<Student>,IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
                
        }
    }
}
