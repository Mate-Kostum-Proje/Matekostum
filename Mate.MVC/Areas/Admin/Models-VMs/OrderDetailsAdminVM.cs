using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mate.MVC.Areas.Admin.Models_VMs
{
    public class OrderDetailsAdminVM
    {
        public string OrderDetailId { get; set; }
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerTcNo { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerDistrict { get; set; }
        public string ProductName { get; set; }
        public int ProductSize { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public string SituationName { get; set; }
        public List<SelectListItem> Situations { get; set; }
        public string SelectedSituationId { get; set; }
    }
}
