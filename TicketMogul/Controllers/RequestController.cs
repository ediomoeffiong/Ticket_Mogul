using Microsoft.AspNetCore.Mvc;
using TicketMogul.Core.ViewModel.Request;

namespace TicketMogul.Controllers
{
    public class RequestController : Controller
    {
        private object RequestService { get; set; }
        public RequestController()
        {

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CreateRequest(CreateRequestViewModel data)
        {
            return Ok();
        }
    }
}
