using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Service.Models.ORM
{
    public class Invoices : BaseModel
    {
        public int InvoiceID { get; set; }
        [ForeignKey("ServiceID")]
        public ServiceRecords ServiceRecords { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public int TotalAmount { get; set; }

    }
}
