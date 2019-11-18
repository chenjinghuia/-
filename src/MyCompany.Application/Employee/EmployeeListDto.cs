using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using MyCompany.Employee;
using System;
using System.Collections.Generic;
using System.Text;
using static MyCompany.Employee.Basic;

namespace MyCompany
{
    [AutoMapFrom(typeof(Basic))]
    public class EmployeeListDto : EntityDto, IHasCreationTime
    {
        public string YGName { get; set; }
        public string Sex { get; set; }
        public string TypeService { get; set; }
        public string Area { get; set; }
        public string Telephone { get; set; }
        public string Introduction { get; set; }
        public DateTime CreationTime { get; set; }
        public TaskState Handle { get; set; }
    }
}
