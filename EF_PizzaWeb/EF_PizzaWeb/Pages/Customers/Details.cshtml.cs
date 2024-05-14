using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EF_PizzaWeb.Data;
using EF_PizzaWeb.Models;
using Castle.Core.Resource;

namespace EF_PizzaWeb.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly EF_PizzaWeb.Data.EfpizzaContext _context;

        public DetailsModel(EF_PizzaWeb.Data.EfpizzaContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers
                        .Include(c => c.Orders)
                        .ThenInclude(o => o.OrderDetails)
                        .ThenInclude(od => od.Product)
                        .FirstOrDefaultAsync(m => m.Id == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
