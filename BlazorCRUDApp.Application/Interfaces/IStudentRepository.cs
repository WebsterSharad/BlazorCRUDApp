

using BlazorCRUDApp.Domain.Entities;

namespace BlazorCRUDApp.Application.Interfaces
{
    public interface IStudentRepository
    {
        Task AddAsync(Students student);
        Task<List<Students>> GetAllStudentsAsync();

        Task<Students?> GetStudentByIdAsync(int id);

        Task UpdateStudent(Students student);
        Task DeleteStudentByIdAsync(int id);
    }
}
