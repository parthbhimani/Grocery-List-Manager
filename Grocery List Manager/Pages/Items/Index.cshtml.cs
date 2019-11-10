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
    public class IndexModel : PageModel
    {
        private readonly Grocery_List_Manager.Models.Grocery_List_ManagerContext _context;

        public IndexModel(Grocery_List_Manager.Models.Grocery_List_ManagerContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Item.ToListAsync();
        }
    }
}
