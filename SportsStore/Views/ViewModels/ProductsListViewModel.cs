using SportsStore.Models;
using SportsStore.Models.ViewModels;
using System.Collections.Generic;

namespace SportsStore.Views.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}