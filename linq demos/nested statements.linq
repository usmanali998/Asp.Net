<Query Kind="Expression">
  <Connection>
    <ID>89b5626c-3013-49b1-b44e-30b91b389f87</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from cat in MenuCategories
orderby cat.Description
select new
{
	Description = cat.Description,
	MenuItems = from item in cat.Items
				where item.Active
				orderby item.Description
				select new
	{
		Description = item.Description,
		Price = item. CurrentPrice,
		Calories = item.Calories,
		Comment = item.Comment
	}
}