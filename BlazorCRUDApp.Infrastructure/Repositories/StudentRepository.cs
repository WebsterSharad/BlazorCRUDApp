

using BlazorCRUDApp.Application.Interfaces;
using BlazorCRUDApp.Domain.Entities;
using BlazorCRUDApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDApp.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly BlazorCRUDAPPDbContext context;
        public StudentRepository(IDbContextFactory<BlazorCRUDAPPDbContext> factory)
        {
            context = factory.CreateDbContext();
        }


        public async Task AddAsync(Students student)
        {
           context.Students.Add(student);
            await context.SaveChangesAsync();
        }

        public async Task<List<Students>> GetAllStudentsAsync()
        {
           var Stud= await context.Students.ToListAsync();
            return Stud;
        }

        public Task<Students?> GetStudentByIdAsync(int id)
        {
          var student=context.Students.FirstOrDefaultAsync(e=>e.Id==id);
            return student;
        }

        public async Task UpdateStudent(Students student)
        {
            context.Entry(student).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task DeleteStudentByIdAsync(int id)
        {
            var student = await GetStudentByIdAsync(id);
            if(student is not null)
            {
                context.Students.Remove(student);
                await context.SaveChangesAsync();
            }
        }

        
         
        
    }
}
