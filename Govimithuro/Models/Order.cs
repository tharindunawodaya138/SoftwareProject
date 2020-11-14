using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Govimithuro.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public float Quantity { get; set; }
        public string RequiredDate { get; set; }
        public string OrderdDate { get; set; }
        public int OrderNumber { get; set; }
    }
}
