using System.Collections.Generic;
using SalesWebMvc.Models;

namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller? Seller { get; set; }
        public List<Department>? Departments { get; set; }
    }
}