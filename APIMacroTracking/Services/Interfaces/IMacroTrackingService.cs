using APIMacroTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMacroTracking.Services
{
    public interface IMacroTrackingService
    {
        List<Item> GetAllItems();
    }
}
