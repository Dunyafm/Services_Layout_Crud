using Microsoft.AspNetCore.Mvc;
using ServiceLayout.Models;
using ServiceLayout.Services;
using ServiceLayout.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayout.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly LayoutService _layoutService;
        public FooterViewComponent(LayoutService layoutService)
        {
            _layoutService = layoutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Category> categories = _layoutService.GetCategories();
            
            LayoutVM layoutVM = new LayoutVM
            {
                Categories = categories,
                
            };
            return (await Task.FromResult(View(layoutVM)));
        }
    }

}

