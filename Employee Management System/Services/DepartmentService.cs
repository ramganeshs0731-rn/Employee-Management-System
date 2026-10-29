using Employee_Management_System.Models;
using Employee_Management_System.Repositories;

namespace Employee_Management_System.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync() => await _departmentRepository.GetAllAsync();

        public async Task<Department?> GetDepartmentByIdAsync(int id) => await _departmentRepository.GetByIdAsync(id);

        public async Task CreateDepartmentAsync(Department department) => await _departmentRepository.AddAsync(department);

        public async Task UpdateDepartmentAsync(Department department) => await _departmentRepository.UpdateAsync(department);

        public async Task DeleteDepartmentAsync(int id) => await _departmentRepository.DeleteAsync(id);
    }
}