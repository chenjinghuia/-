using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyCompany.Customers
{
    [Table("Customer")]
    public class Customer : Entity
    {
        public const int MaxKHNameLength = 256;
        [Required]
        [StringLength(MaxKHNameLength)]
        public string KHName { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public int TransactionNumber { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Order OrderCustomer { get; set; }
        public Guid ? CustomerId { get; set; }
        public Customer(string KHname, Guid ? customerId = null)
            : this()
        {
            KHName = KHname;
            CustomerId = customerId;
        }
        public Customer()
        {
        }

    }
}
