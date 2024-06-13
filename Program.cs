// See https://aka.ms/new-console-template for more information


using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

List <Plant> plants = new List<Plant>()
{
    new Plant()
    {
        Species = "Aloe",
        LightNeeds = 5,
        AskingPrice = 5.00M,
        City = "Nashville",
        ZIP = "37212",
        Sold = false,
        AvailableUntil = new DateTime(2024, 7, 23)

    },
    new Plant()
    {
        Species = "Fern",
        LightNeeds = 3,
        AskingPrice = 10.00M,
        City = "Portland",
        ZIP = "97205",
        Sold = true,
        AvailableUntil = new DateTime(2024, 5, 23)
    },

    new Plant()
    {
        Species = "Cactus",
        LightNeeds = 5,
        AskingPrice = 15.00M,
        City = "Phoenix",
        ZIP = "85001",
        Sold = false,
        AvailableUntil = new DateTime(2024, 8, 23)
    },

    new Plant()
    {
        Species = "Orchid",
        LightNeeds = 4,
        AskingPrice = 25.00M,
        City = "Miami",
        ZIP = "33101",
        Sold = false,
        AvailableUntil = new DateTime(2024, 6, 26)
    },

    new Plant()
    {
        Species = "Bamboo",
        LightNeeds = 2,
        AskingPrice = 8.00M,
        City = "San Francisco",
        ZIP = "94103",
        Sold = true,
        AvailableUntil = new DateTime(2024, 3, 23)
    }

};

Console.WriteLine("Here are some plants SUCKA!");

    Random random = new Random();
    
string PlantDetails(Plant plant)
{
    string plantString = $"{plant.Species} in {plant.City} {(plant.Sold ? "was sold" : "is available")} for {plant.AskingPrice}";

    return plantString;

}

void ListPlants()
{
for(int i = 0; i <plants.Count; i++)
{

   Console.WriteLine($"{i + 1 }. {PlantDetails(plants[i])}");
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

    DateTime date = new DateTime();

bool validInput = false;

    while(!validInput)
    {
        Console.WriteLine(@"
        Enter a date your plant will be available until in the following format MM/DD/YYYY");
        try
        {
            date = DateTime.Parse(Console.ReadLine());
            validInput= true;
        }
        catch(FormatException ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine(@"
            Please enter a date in the following format MM/DD/YYYY");
        }
    }

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

void AdoptPlant()
{
    for(int i = 0; i < plants.Count; i++)
    {
        if(!plants[i].Sold && plants[i].AvailableUntil > DateTime.Now)
        {
            Console.WriteLine($"{i}. {plants[i].Species}");
        }
    }
    Console.WriteLine(@"
    Please choose a plant to adopt.");
    int choice = int.Parse(Console.ReadLine());
    plants[choice].Sold = true;

    Console.WriteLine($"Congratulations! You have adopted a {plants[choice].Species}. Carry on...");

}

void DeletePlant()
{
    ListPlants();

    Console.WriteLine("Which plant do you want to delete?");

    int choice = int.Parse(Console.ReadLine());

    plants.RemoveAt(choice -1);

    Console.WriteLine("Delete successful");

}

int getRandomInteger(int len)
{
    return random.Next(len);
}

void ListRandomPlant()
{
    int length = plants.Count;
    int randomInteger = getRandomInteger(length);

    while(plants[randomInteger].Sold != false)
    {
        randomInteger = getRandomInteger(length);
    }
 Console.WriteLine($"The {plants[randomInteger].Species} resides in {plants[randomInteger].City}, has a {plants[randomInteger].LightNeeds} on the light scale and costs {plants[randomInteger].AskingPrice}");
}

void SearchPlants()
{
    Console.WriteLine(@"
    Enter the maximum light requirement for your plant
    ");
    
    int choice = int.Parse(Console.ReadLine());

    foreach(Plant plant in plants)
    {
        if (plant.LightNeeds <= choice)
        {
            Console.WriteLine($"{plant.Species}");
        }
    }

}

string getLowestPriced()
{
    Plant lowestPriced = null;
    decimal lowestPrice = 1000.00M;

    foreach (Plant plant in plants)
    {
        if (plant.AskingPrice < lowestPrice)
        {
            lowestPrice = plant.AskingPrice;
            lowestPriced = plant;
        }
    }

    return lowestPriced.Species;

}

int getTotalNumberPlants()
{
    int counter = 0;

    foreach (Plant plant in plants)
    {
        if (!plant.Sold && plant.AvailableUntil > DateTime.Now)
        {
            counter++;
        }
    }

    return counter;
}

string getHighestLightNeedPlant()
{
    Plant highestLightNeed = null;
    int lightNeed = 0;

    foreach (Plant plant in plants)
    {
        if(plant.LightNeeds > lightNeed)
        {
        highestLightNeed = plant;
        lightNeed = plant.LightNeeds;

        }
    }
    return highestLightNeed.Species;
}

int getAverageLightNeed()
{
    int counter = 0;

    foreach (Plant plant in plants)
    {
        counter += plant.LightNeeds;
    }
    int average = counter / plants.Count;

    return average;
}

double getPercentageAdopted()
{
    int numberAdopted = 0;

    foreach(Plant plant in plants)
    {
        if(plant.Sold)
        {
            numberAdopted++;
        }
    }
    double percentage = ((double) numberAdopted / (double)plants.Count) * 100;

    return percentage;
}

void ViewStatistics()
{
    string lowestPriced = getLowestPriced();
    int totalPlants = getTotalNumberPlants();
    string highestLightNeeds = getHighestLightNeedPlant();
    int averageLightNeeds = getAverageLightNeed();
    double percentageAdopted = getPercentageAdopted();

    Console.WriteLine(@$"Here are some plant statistics
    1. {lowestPriced} is the lowest priced plant.
    2. There are a total of {totalPlants} plants listed for adoption
    3. {highestLightNeeds} is the plant with the highest light need
    4. The average light need is {averageLightNeeds}
    5.{percentageAdopted}% of plants are adopted 
    ");
}


string choice = "";

while (choice != "h")
{
      Console.WriteLine(@"
  Please choose an option:
  a. Display all Plants
  b. Post a plant to be adopted
  c. Adopt a Plant
  d. Delist a plant
  e. See Random Plant of the Day
  f. Search Plants
  g. View Statistics
  h. Exit
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
        AdoptPlant();
        break;
    case "d" :
        DeletePlant();
        break;
    case "e" :
        ListRandomPlant();
        break;
     case "f" :
        SearchPlants();
        break;
    case "g" :
        ViewStatistics();
        break;
    case "h" :
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
