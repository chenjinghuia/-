using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCompany.Employee
{
    [Table("Certificate")]
    public class Certificate : Entity<int>
    {
        public const int MaxYGNameLength = 32;
        [Required]
        [StringLength(MaxYGNameLength)]
        public string YGName { get; set; }
        public string Identity { get; set; }
        public string Professional { get; set; }
        public string Qualification { get; set; }
        public Certificate(string name)
        {
            YGName = name;
        }
        public Certificate()
        {

        }


    }
}
