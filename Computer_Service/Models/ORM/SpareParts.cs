using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Service.Models.ORM
{
    public class SpareParts : BaseModel
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

    }
}
