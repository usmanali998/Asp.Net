<Query Kind="Expression">
  <Connection>
    <ID>840bae15-42a0-45bc-bf82-0e8243563b32</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from data in Waiters
where data.ReleaseDate ==null
select data
