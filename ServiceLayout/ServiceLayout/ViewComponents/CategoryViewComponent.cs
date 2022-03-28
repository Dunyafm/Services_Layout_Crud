using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceLayout.Data;
using ServiceLayout.Models;
using ServiceLayout.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayout.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public CategoryViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Category> categories = await _context.Categories.Include(m => m.Categories).ToListAsync();
           

            CategoryVM categoryVM = new CategoryVM()
            {
                Categories = categories,
               
            };


            return await Task.FromResult(View(categoryVM));
        }
    }

}

