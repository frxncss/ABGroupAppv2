namespace ABGroupAppv2
{
    public class BookingFinalDocsDTO
    {
        public string bookingReference { get; set; }
        public string bookingName { get; set; }
        public string consultantName { get; set; }
        public string agentName { get; set; }
        public string agentCountry { get; set; }
        public DateTime pickUpDate { get; set; }
        public DateTime dropOffDate { get; set; }
        public int? adults { get; set; }
        public int? guides { get; set; }
        public int? children { get; set; }
        public int? drivers { get; set; }
        public int? tourLeader { get; set; }
        public AttachmentDTO bookingItinerary { get; set; }
        public List<ServiceDetailsDTO> bookingService { get; set; }
    }

}
