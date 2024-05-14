using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EF_PizzaWeb.Data;
using EF_PizzaWeb.Models;

namespace EF_PizzaWeb.Pages.CRUDProducts
{
    public class IndexModel : PageModel
    {
        private readonly EF_PizzaWeb.Data.EfpizzaContext _context;

        public IndexModel(EF_PizzaWeb.Data.EfpizzaContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}
