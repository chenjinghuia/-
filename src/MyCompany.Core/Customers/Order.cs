using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyCompany.Customers
{
    [Table(" Order")]
    public class Order : Entity<Guid>
    {
        public const int MaxKHNameLength = 32;
        [Required]
        [StringLength(MaxKHNameLength)]
        public string KHName { get; set; }
        public int OrderID { get; set; }
        public string OderMoney { get; set; }
        public string OderAddress { get; set; }
        public DateTime OrderStartTime { get; set; }
        public DateTime OrderOverTime { get; set; }
        public string ServiceEployee { get; set; }
        
        public Order(string name)
        {
            KHName = name;
        }
        public Order()
        {

        }


    }
}
