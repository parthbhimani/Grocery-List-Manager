using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Grocery_List_Manager.Models;

namespace Grocery_List_Manager.Pages.Items
{
    public class DetailsModel : PageModel
    {
        private readonly Grocery_List_Manager.Models.Grocery_List_ManagerContext _context;

        public DetailsModel(Grocery_List_Manager.Models.Grocery_List_ManagerContext context)
        {
            _context = context;
        }

        public Item Item { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Item = await _context.Item.FirstOrDefaultAsync(m => m.Id == id);

            if (Item == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
