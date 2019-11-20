using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCompany.Employee
{
    [Table("Basic")]
    public class Basic : Entity,IHasCreationTime
    {
        public const int MaxYGNameLength = 256;   
        [Required]
        [ForeignKey(nameof(EmployeeId))]
        public Record EmployeeRecord { get; set; }
        public Guid ? EmployeeId { get; set; }
        [StringLength(MaxYGNameLength)]
        public string YGName { get; set; }
        public string Sex { get; set; }
        public string TypeService { get; set; }
        public string Area { get; set; }
        public string Telephone { get; set; }
        public string Introduction { get; set; }
        public DateTime CreationTime { get; set; }
        public string Identity { get; set; }
        public string Professional { get; set; }
        public string Qualification { get; set; }
        public TaskState Handle { get; set; }

       
        public Basic(string YGname,  Guid ? employeeId = null)
            : this()
        {
            YGName = YGname;
            EmployeeId = employeeId;
        }
        public Basic()
        {
            CreationTime = Clock.Now;
            Handle = TaskState.Add;
        }
        public enum TaskState : byte
        {
            Select = 1,
            Add= 2,
            Update=3,
            delete=4

        }

    }
}
