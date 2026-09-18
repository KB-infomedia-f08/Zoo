using Newtonsoft.Json;

class Lion : Animal
{
    bool IsMale { get; set; }
    [JsonConstructor]
    public Lion(string name, int age, int wellbeing, bool isMale) : base(name, age, wellbeing)
    {
        IsMale = isMale;
    }

    public Lion() : base()
    {
        Console.WriteLine("Is The Lion male [Y/N]");
        switch (Console.ReadLine())
        {
            case "Y":
                IsMale = true;
                break;
            case "N":
                IsMale = false;
                break;
        }
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
                if (input == "Y")
                {
                    IsMale = true;
                }
                else
                {
                    IsMale = false;
                }
                break;
            default:
                break;
        }
    }
}
