using System.Threading.Tasks;
using System;

namespace ABGroupAppv2
{
    public class SupplierBookingDTO
    {
        public string bookingReference { get; set; }
        public DateTime pickUpDate { get; set; }
        public DateTime dropOffDate { get; set; }
    }
}
