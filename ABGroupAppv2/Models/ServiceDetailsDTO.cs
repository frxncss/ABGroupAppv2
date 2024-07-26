namespace ABGroupAppv2
{
    public class ServiceDetailsDTO
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
        public string? supplierPhone { get; set; }
        public string? roomingList { get; set; }
        public string? supplierCode { get; set; }
        public AttachmentDTO pdfRoomingList { get; set; }
    }

}
