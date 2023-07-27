using WebApplication1.Data;
using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.Models
{
    public class HomeViewModel
    {
        public DataInvoicesPay DataInvoicesPay { get; set; }
        public List<DataInvoicesPay> DataInvoicesPays { get; set; }

    }
}