using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTecnica.Entity.ViewModels
{
    class OrderViewModel
    {
        public Order Order { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItemViewModel> Items { get; set; }

    }
}
