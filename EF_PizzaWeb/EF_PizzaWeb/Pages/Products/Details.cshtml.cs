using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EF_PizzaWeb.Data;
using EF_PizzaWeb.Models;

namespace EF_PizzaWeb.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly EfpizzaContext _context;

        public DetailsModel(EfpizzaContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id, int customerId)
        {
            if (id == null)
            {
                return NotFound();
            }
            CustomerId = customerId;

            Product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            Product = await _context.Products.FindAsync(id);

            if (Product == null)
            {
                return NotFound();
            }

            if (CustomerId > 0)
            {
                Customer = await _context.Customers
                    //.Where(c => c.Id == CustomerId)
                    .FromSqlInterpolated($"SELECT * FROM Customers WHERE Id = {CustomerId}")
                    .FirstOrDefaultAsync();
            }

            return Page();
        }
    }
}
