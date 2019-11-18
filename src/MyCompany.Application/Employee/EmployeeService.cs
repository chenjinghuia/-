using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;

namespace MyCompany.Employee
{
    public class EmployeeService : MyCompanyAppServiceBase, IEmployeeService
    {
        private readonly IRepository<Basic> _taskRepository;

        public EmployeeService(IRepository<Basic> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<ListResultDto<EmployeeListDto>> GetAll(GetAllEmployeeInput input)
        {
            var tasks = await _taskRepository
                .GetAll()
                .WhereIf(input.Handle.HasValue, t => t.Handle == input.Handle.Value)
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<EmployeeListDto>(
                ObjectMapper.Map<List<EmployeeListDto>>(tasks)
            );
        }
    }
}
