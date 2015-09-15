<Query Kind="Expression">
  <Connection>
    <ID>89b5626c-3013-49b1-b44e-30b91b389f87</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//Anonymus Types2.linq
from person in Waiters
where person.ReleaseDate == null // people still employed
select new
{
	Name= person.FirstName + " " + person.LastName,
	Phone= person.Phone,
	DaysEmployed = (DateTime.Today - person.HireDate).Days
}