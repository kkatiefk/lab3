using _2sem_lab3;
Variables v = new Variables(2, 5);
Console.WriteLine("Two variables:");
v.Write();

v.Change(12, 100);
Console.WriteLine("\nChanged variables:");
v.Write();

Console.WriteLine("\nThe sum of this two variables: " + v.Sum());


Console.WriteLine("\nThe maximum of this two variables: " + v.Max());

string filePath = "variables.json";
v.SaveToJson(filePath);
Console.WriteLine($"\nObject saved to {filePath}");

Console.WriteLine("\nContent of saved JSON file:");
string jsonContent = File.ReadAllText(filePath);
Console.WriteLine(jsonContent);

Variables loadedV = Variables.LoadFromJson(filePath);
Console.WriteLine("\nLoaded variables from JSON:");
loadedV.Write();

Console.ReadKey();


