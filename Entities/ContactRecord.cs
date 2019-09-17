using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ContactRecord
    {
        public int id { get; set; }

        public String firstName { get; set; }

        public String lastName { get; set; }

        public String mobileNumber { get; set; }

        public String homeNumber { get; set; }

        public String businessNumber { get; set; }

        public String address { get; set; }

        public String notes { get; set; }

        public Boolean Active { get; set; }
    }
}
