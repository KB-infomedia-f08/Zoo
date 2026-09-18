

abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Wellbeing { get; set; }
    public List<string> attributes = ["Name", "Age", "Wellbeing"];
    public Animal(string name, int age, int wellbeing)
    {
        Name = name;
        Age = age;
        Wellbeing = wellbeing;
    }

    public Animal() {
        Console.WriteLine("Enter name");
        Name = Console.ReadLine();
        Console.WriteLine("Enter Age");
        Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Wellbeing");
        Wellbeing = Convert.ToInt32(Console.ReadLine());
    }

    public override string ToString()
    {
        return Name + " : " + GetType().Name;
    }

    public virtual void Edit()
    {
        Console.Clear();
        for (int i = 0; i < attributes.Count; i++)
        {
            Console.WriteLine($"[{i + 1}] " + attributes[i]);
        }
        Console.WriteLine("Select attribute to edit");
    }
}
