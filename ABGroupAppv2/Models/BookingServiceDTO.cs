using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABGroupAppv2.Models
{
    public class Bookingservice
    {
        public string supplierName { get; set; }
        public DateTime serviceDate { get; set; }
        public string productOptionName { get; set; }
        public int bsL_ID { get; set; }
        public DateTime pickUpDate { get; set; }
        public string pickUpTime { get; set; }
        public string pickUpDetails { get; set; }
        public DateTime dropOffDate { get; set; }
        public string dropOffTime { get; set; }
        public string dropOffDetails { get; set; }
        public string serviceVoucher { get; set; }
        public DateTime travelDate { get; set; }
        public string bookingName { get; set; }
        public int bhD_ID { get; set; }
    }

}
