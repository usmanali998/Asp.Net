<Query Kind="Expression">
  <Connection>
    <ID>89b5626c-3013-49b1-b44e-30b91b389f87</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// List all the menu items that are Entrees in order from the most to the least Expensive

from food in Items
where food.MenuCategory.Description == "Entree"
 || food.MenuCategory.Description =="Beverage"
orderby food.CurrentPrice descending
group food by food.MenuCategoryID into result
select result