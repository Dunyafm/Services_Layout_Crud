using ServiceLayout.Data;
using ServiceLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayout.Services
{
    public class ServiceLayout
    {
        private readonly AppDbContext _context;
        public ServiceLayout(AppDbContext context)
        {
            _context = context;
        }

        public Dictionary<string, string> GetSettings()
        {
            return _context.Settings.AsEnumerable().ToDictionary(m => m.Key, m => m.Value);
        }

        internal List<Category> GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}




  