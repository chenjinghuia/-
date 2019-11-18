using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;

namespace MyCompany
{
    public interface IEmployeeService : IApplicationService
    {
        Task<ListResultDto<EmployeeListDto>> GetAll(GetAllEmployeeInput input);
    }
}
