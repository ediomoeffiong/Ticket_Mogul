using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMogul.Core.ViewModel.Request
{
    public class CreateRequestViewModel
    {
        public string Name { get; set; }
        public DateTime CreatedTime { get; set; }
        public string Service { get; set; }
    }
}
