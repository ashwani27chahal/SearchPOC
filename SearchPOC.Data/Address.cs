using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchPOC.Data
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }

        //public virtual Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
