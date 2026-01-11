using System.Dynamic;

Console.Write("Please, specify the number of floors: ");
int flrs = int.Parse(Console.ReadLine());
Console.Write("Please, specify the number of bulding entrances: ");
int entrs = int.Parse(Console.ReadLine());
Console.Write("Please, specify the number of apatments per floor: ");
int apts = int.Parse(Console.ReadLine());

int width = apts * entrs;

if (flrs < 11)
{
    Console.WriteLine("Bulding must be at least 11 floors to make a Georgian flag");
    return;
}

if (width < 11)
{
    Console.WriteLine("Product of entrances and apartments per floor must be at least 11 to make a Georgian flag");
    return;
}

for (int e = 1; e <= entrs; e++)
{
    for (int f = 1; f <= flrs + 1; f++)
    {
        for (int fpf = 1; fpf <= apts; fpf++)
        {
            
        }
        
    }
    
}  

