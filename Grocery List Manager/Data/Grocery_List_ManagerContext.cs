using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Grocery_List_Manager.Models
{
    public class Grocery_List_ManagerContext : DbContext
    {
        public Grocery_List_ManagerContext (DbContextOptions<Grocery_List_ManagerContext> options)
            : base(options)
        {
        }

        public DbSet<Grocery_List_Manager.Models.Item> Item { get; set; }
    }
}
