using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABGroupAppv2.Models
{
    public class ServiceDTO
    {
        public string bookingReference { get; set; }
        public DateTime pickUpDate { get; set; }
        public DateTime dropOffDate { get; set; }
    }
}
