using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MyCompany.Employee.Basic;

namespace MyCompany.Web.Model
{
    public class IndexViewModel
    {
        public IReadOnlyList<EmployeeListDto> Employees { get; }

        public IndexViewModel(IReadOnlyList<EmployeeListDto> employee)
        {
            Employees = employee;
        }

        public string GetTaskLabel(EmployeeListDto task)
        {
            switch (task.Handle)
            {
                case TaskState.Add:
                    return "label-success";
                default:
                    return "label-default";
            }
        }
    }
}
