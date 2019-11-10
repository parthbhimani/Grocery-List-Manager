using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery_List_Manager.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Quantity { get; set; }
        public bool Purchased { get; set; }
    }
}
