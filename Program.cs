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

// foreach(Plant plant in plants)
// {
//     Console.WriteLine($"{}")
// }

for(int i = 0; i <plants.Count; i++)
{
    Console.WriteLine($"{i + 1 }. {plants[i].Species}");
}