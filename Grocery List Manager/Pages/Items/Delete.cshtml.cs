﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Grocery_List_Manager.Models;

namespace Grocery_List_Manager.Pages.Items
{
    public class DeleteModel : PageModel
    {
        private readonly Grocery_List_Manager.Models.Grocery_List_ManagerContext _context;

        public DeleteModel(Grocery_List_Manager.Models.Grocery_List_ManagerContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Item = await _context.Item.FindAsync(id);

            if (Item != null)
            {
                _context.Item.Remove(Item);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
