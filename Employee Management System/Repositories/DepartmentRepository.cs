using Employee_Management_System.Data;
using Employee_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_System.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Department>> GetAllAsync() => await _context.Departments.Include(d => d.Employees).ToListAsync();

        public async Task<Department?> GetByIdAsync(int id) => await _context.Departments.Include(d => d.Employees).FirstOrDefaultAsync(d => d.Id == id);

        public async Task AddAsync(Department department)
        {
            await _context.Departments.AddAsync(department);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Department department)
        {
            _context.Departments.Update(department);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var department = await GetByIdAsync(id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                await _context.SaveChangesAsync();
            }
        }
    }
}