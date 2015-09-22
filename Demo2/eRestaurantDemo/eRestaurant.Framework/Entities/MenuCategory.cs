using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Framework.Entities
{
   public  class MenuCategory
    {
       [Key] // This attribute identifies the Menu CategoryID property as mapping to a primary key
       public int MenuCategoryID{get; set;}
       public string Description { get; set; }
       // Navigation Property
       public virtual ICollection<Item> Items { get; set; }
    }
}
