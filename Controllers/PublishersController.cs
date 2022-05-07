using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reminder.Data.Services;
using Reminder.Data.ViewModels;

namespace Reminder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : Controller
    {
        private PublishersService _publishersService;
        
        public PublishersController(PublishersService publishersService)
        {
            _publishersService = publishersService;
        }

        [HttpPost("add-publisher")]
        public IActionResult AddPublisher([FromBody]PublisherVM publisher)
        {
            _publishersService.AddPublisher(publisher);
            return Ok();
        }
    }
}