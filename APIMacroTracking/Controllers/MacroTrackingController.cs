using APIMacroTracking.Models;
using APIMacroTracking.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMacroTracking.Controllers
{
    [ApiController]
    [Route("TEST")]
    public class MacroTrackingController : ControllerBase
    {
        private readonly IMacroTrackingService service;

        public MacroTrackingController(IMacroTrackingService service)
        {
            this.service = service;
        }

        [HttpGet("Testing")]
        public IEnumerable<Item> Get()
        {
            return service.GetAllItems();
        }
    }
}
