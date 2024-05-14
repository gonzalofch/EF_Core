using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EF_PizzaWeb.Data;
using EF_PizzaWeb.Models;

namespace EF_PizzaWeb.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly EfpizzaContext _context;

        public IndexModel(EfpizzaContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get; set; } = default!;


        public async Task OnGetAsync()
        {
            if (_context.Customers != null)
            {
                Customer = await _context.Customers
                    .Include(c=>c.Orders)
                    .ToListAsync();
            }
        }

        /*
         
        public async Task OnGetAsync()
        {
            if (_context.Customers != null)
            {
                Customer = await _context.Customers
                    .Include(c=>c.Orders)
                     .AsNoTracking()
                    .ToListAsync();
            }
        }*/
    }
}
