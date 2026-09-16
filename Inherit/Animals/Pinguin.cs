using static System.Net.Mime.MediaTypeNames;

class Pinguin : Animal
{
    bool IsOnLand {  get; set; }
    public Pinguin(string name, int age, int wellbeing, bool isOnLand) : base(name, age, wellbeing)
    {
        IsOnLand = isOnLand;
    }
    public Pinguin() :base()
    {
        Console.WriteLine("Is The Pinguin on land [Y/N]");
        switch (Console.ReadLine())
        {
            case "Y":
                IsOnLand = true;
                break;
            case "N":
                IsOnLand = false;
                break;
        }
    }
}
