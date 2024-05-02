namespace ABGroupAppv2.Models
{
    public class PassResetDTO
    {
        public string SupplierCode { get; set; }
        public string Email { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
