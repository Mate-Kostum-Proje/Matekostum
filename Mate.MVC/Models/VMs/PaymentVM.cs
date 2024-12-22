namespace Mate.MVC.Models.VMs
{
    public class PaymentVM
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string CVV { get; set; }
        public decimal Amount { get; set; }
    }
}
