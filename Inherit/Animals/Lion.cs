class Lion : Animal
{
    bool IsMale { get; set; }
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
}
