using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ServiceLayout.Data;
using ServiceLayout.Models;
using ServiceLayout.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayout.ViewComponents
{
    public class BasketViewComponent : ViewComponent
    {

        private readonly AppDbContext _context;
        public BasketViewComponent(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {

            List<BasketVM> basket;
            if (Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            }
            else
            {
                basket = new List<BasketVM>();
            }
            List<BasketDetailVM> basketDetailsItem = new List<BasketDetailVM>();

            foreach (BasketVM basketItem in basket)
            {

                Product product = await _context.Products.Include(m => m.Image).FirstOrDefaultAsync(m => m.Id == basketItem.Id);

                BasketDetailVM basketDetail = new BasketDetailVM
                {
                    Id = basketItem.Id,
                    Name = product.Name,
                    Count = basketItem.Count,
                    Price = product.Price * basketItem.Count
                };

                basketDetailsItem.Add(basketDetail);
            }
            return await Task.FromResult(View(basketDetailsItem));
        }
    }
}

