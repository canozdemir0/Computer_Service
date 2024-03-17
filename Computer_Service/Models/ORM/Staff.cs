using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Service.Models.ORM
{
    public class Staff : BaseModel
    {
        public int StafID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Pozition { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
    }
}
