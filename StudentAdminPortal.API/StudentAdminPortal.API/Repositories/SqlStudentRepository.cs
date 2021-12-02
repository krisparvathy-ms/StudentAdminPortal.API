using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext context; //throughout this SqlStudentRepo we'll use this context to talk to our databse

        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }

        public async Task<Student> GetStudentAsync(Guid StudentId)
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address))
                .FirstOrDefaultAsync(x => x.Id == StudentId);
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            // return context.Student.ToList(); //linq query
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }

    }
}
