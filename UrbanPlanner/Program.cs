using UrbanPlanner;


Building LAndC = new Building("123 Union St.", "Terry Pluckens")
{
    Stories = 70,
    Width = 45.25,
    Height = 900.33

};
Building Batman = new Building("222 Commerce St.", "Quint Horton")
{
    Stories = 80,
    Width = 48.75,
    Height = 989.40

}; 
Building BridgeStone = new Building("445 Broadway", "Solomon Gumball")
{
    Stories = 15,
    Width = 400.25,
    Height = 300.86

};

LAndC.Construct();
Batman.Construct();
BridgeStone.Construct();    

LAndC.Purchase("Dorf Goldman");
Batman.Purchase("Petunia Longfloss");
BridgeStone.Purchase("Vigo Vesputin");

List<Building> buildings = new List<Building>();

buildings.Add(LAndC);
buildings.Add(Batman);  
buildings.Add(BridgeStone);

foreach (Building tower in buildings)
{
    Console.WriteLine(tower.DisplayInfo());
}

Console.ReadLine();