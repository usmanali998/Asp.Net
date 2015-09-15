<Query Kind="Program">
  <Connection>
    <ID>89b5626c-3013-49b1-b44e-30b91b389f87</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

void Main()
{
	var students= Names();
	//students.Dump();
	var lastInitial_s= from person in students
					   where person.Contains(" S")
					   select person;
	lastInitial_S.Dump("People whose last name starts with 'S' ");				   
}
	
// Define other methods and classes here
public List<string> Names()
{
	List<string> data= new List<string>();
	data.Add("Bob Saudareesda");
	data.Add("Bob Saequdasda");
	data.Add("Bob Sqqaudasda");
	data.Add("Bob Sweaudasrda");
	data.Add("Bob Saudawewsda");
	data.Add("Bob Saugwdasda");
	data.Add("Bob Sasdudasda");
	return data;
	
}