

using Newtonsoft.Json;

class Pinguin : Animal
{
    bool IsOnLand {  get; set; }
    [JsonConstructor]
    public Pinguin(string name, int age, int wellbeing, bool isOnLand) : base(name, age, wellbeing)
    {
        IsOnLand = isOnLand;
        attributes.Add("Is on Land [Y/N]");
    }
    public Pinguin() : base()
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
        attributes.Add("Is on Land [Y/N]");
    }
    public override void Edit()
    {
        base.Edit();
        switch (Console.ReadLine())
        {
            case "1":
                Name = Console.ReadLine();
                break;
            case "2":
                Age = Convert.ToInt32(Console.ReadLine());
                break;
            case "3":
                Wellbeing = Convert.ToInt32(Console.ReadLine());
                break;
            case "4":
                string input = Console.ReadLine();
                if(input == "Y")
                {
                    IsOnLand = true;
                } else
                {
                    IsOnLand = false;
                }
                    break;
            default:
                break;
        }

    }
}
