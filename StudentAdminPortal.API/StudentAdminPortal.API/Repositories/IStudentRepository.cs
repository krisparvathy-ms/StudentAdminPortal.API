using StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
        Task<Student> GetStudentAsync(Guid StudentId);
        Task<List<Gender>> GetGendersAsync();

        Task<bool> Exists(Guid StudentId);

        Task<Student> UpdateStudent(Guid StudentId,Student request);
        Task<Student> DeleteStudent(Guid studentId);

        Task<Student> AddStudent(Student request);


    }
}
