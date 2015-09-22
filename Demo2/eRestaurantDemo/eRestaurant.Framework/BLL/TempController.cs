﻿using System;
using eRestaurant.Framework.DAL;
using System.Data.Entity;// Needed for the Db Context and other EF classes
using eRestaurant.Framework.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Framework.BLL
{
   public class TempController
    {
       public List<MenuCategory> ListMenuCategories()
       {
           using(var context = new RestaurantContext())
           {
               var data = from category in context.MenuCategories
                          select category;
               return data.ToList();
           }
       }
    }
}
