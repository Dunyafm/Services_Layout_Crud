using Microsoft.AspNetCore.Mvc;
using ServiceLayout.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayout.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly Services.ServiceLayout _layoutService;
        public HeaderViewComponent(Services.ServiceLayout layoutService)
        {
            _layoutService = layoutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Dictionary<string, string> settings = _layoutService.GetSettings();

            return await Task.FromResult(View(settings));
        }
    }
}

