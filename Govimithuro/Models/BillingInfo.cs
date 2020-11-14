using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Govimithuro.Models
{
    public class BillingInfo
    {
        [Key]
        public int BillingId { get; set; }
        public int CardNo { get; set; }
        public string ExpDate { get; set; }
        public string BillDate { get; set; }
        
    }
}
