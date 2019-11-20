using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCompany.Employee
{
    [Table(" Record")]
    public class Record : Entity<Guid>
    {
        public const int MaxYGNameLength = 32;
        [Required]
        [StringLength(MaxYGNameLength)]
        public string YGName { get; set; }
        public string Log { get; set; }
        public DateTime ServiceStartTime { get; set; }
        public DateTime ServiceOverTime { get; set; }
        public string CustomerData { get; set; }
        public string CustomerEvaluation { get; set; }
        public Record(string name)
        {
            YGName = name;
        }
        public Record()
        {

        }


    }
}
