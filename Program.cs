// See https://aka.ms/new-console-template for more information


List <Plant> plants = new List<Plant>()
{
    new Plant()
    {
        Species = "Aloe",
        LightNeeds = 5,
        AskingPrice = 5.00M,
        City = "Nashville",
        ZIP = "37212",
        Sold = false

    },
    new Plant()
    {
        Species = "Fern",
        LightNeeds = 3,
        AskingPrice = 10.00M,
        City = "Portland",
        ZIP = "97205",
        Sold = true
    },

    new Plant()
    {
        Species = "Cactus",
        LightNeeds = 5,
        AskingPrice = 15.00M,
        City = "Phoenix",
        ZIP = "85001",
        Sold = false
    },

    new Plant()
    {
        Species = "Orchid",
        LightNeeds = 4,
        AskingPrice = 25.00M,
        City = "Miami",
        ZIP = "33101",
        Sold = false
    },

    new Plant()
    {
        Species = "Bamboo",
        LightNeeds = 2,
        AskingPrice = 8.00M,
        City = "San Francisco",
        ZIP = "94103",
        Sold = true
    }

};

Console.WriteLine("Here are some plants SUCKA!");

void ListPlants()
{
for(int i = 0; i <plants.Count; i++)
{

   Console.WriteLine($"{i + 1 }. {plants[i].Species} in {plants[i].City} {(plants[i].Sold ? "was sold" : "is available")} for {plants[i].AskingPrice}");
}

}

void AddPlant()
{
    Console.WriteLine("Name your plant");
    string name = Console.ReadLine();
    
    Console.WriteLine("Enter the plant light needs (1-5) with 5 being the most light");
    int light = int.Parse(Console.ReadLine());

    Console.WriteLine("Name your price");
    decimal price = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Enter the city your plant is in");
    string city = Console.ReadLine();

    Console.WriteLine("Enter the zip code");
    string zip = Console.ReadLine();

    Plant PlantToAdd = new Plant()
    {
        Species = name,
        LightNeeds = light,
        AskingPrice = price,
        City = city,
        ZIP = zip,
        Sold = false

    };

    Console.WriteLine(@"Adding plant to database...");

    plants.Add(PlantToAdd);

    ListPlants(); 
    

}

string choice = "";

while (choice != "e")
{
      Console.WriteLine(@"
  Please choose an option:
  a. Display all Plants
  b. Post a plant to be adopted
  c. Adopt a Plant
  d. Delist a plant
  e. Exit
  ") ;

choice = Console.ReadLine();

  switch(choice)
  {
    case "a" : 
        ListPlants();
        break;
    case "b" :
        AddPlant();
        break;
    case "c" :
        throw new NotImplementedException();
        // Console.WriteLine("Adopt a plant");
        // break;
    case "d" :
        throw new NotImplementedException();
        // Console.WriteLine("Delist a plant");
        // break;
    case "e" :

        Console.Clear();
        Console.WriteLine("Oy, fek off");
        break;
    default:
        Console.Clear();
        Console.WriteLine("Hey dummy, choose something bitter");
        break;

  }
}




// foreach(Plant plant in plants)
// {
//     Console.WriteLine($"{}")
// }
