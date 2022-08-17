using APIMacroTracking.Contexts;
using APIMacroTracking.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMacroTracking.Services
{
    public class MacroTrackingService : IMacroTrackingService
    {
        protected readonly IConfiguration config;
        protected readonly MacroTrackingDBContext context;

        public MacroTrackingService(IConfiguration config, MacroTrackingDBContext context)
        {
            this.config = config;
            this.context = context;
        }

        public List<Item> GetAllItems()
        {
            return context.Items.ToList();
        }
    }
}
