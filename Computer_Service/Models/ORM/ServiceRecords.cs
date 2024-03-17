using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Service.Models.ORM
{
    public class ServiceRecords : BaseModel
    {
        public int ServiceId { get; set; }

    
        public int CustomerId { get; set; }
        public string DeviceType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int SeriesNumber { get; set; }
        public string FaultDescription { get; set; }
        public DateTime DateOfAcceptance { get; set; }
        public DateTime EstimatedCompletionDate { get; set; }
        [ForeignKey("StatusId")]
        public int StatusID { get; set; }

        [ForeignKey("CustomerId")]
        public Customer customer { get; set; }

    }
}
