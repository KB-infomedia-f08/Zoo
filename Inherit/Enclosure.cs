class Enclosure
{
    public List<Animal> animals {  get; set; }
    public int Size { get; set; }
    public int Popularity { get; set; }
    public Enclosure()
    {
        animals = new List<Animal>();
    }

    public Enclosure(List<Animal> animals, int size, int popularity)
    {
        this.animals = animals;
        Size = size;
        Popularity = popularity;
    }

    public void View()
    {
        bool isViewing = true;
        while (isViewing)
        {
            Console.Clear();
            for(int i = 0;  i < animals.Count; i++)
            {
                Console.WriteLine($"[{i+1}]" + animals[i]);
            }
            Console.WriteLine("[1] Remove animal\n" +
                              "[2] Edit animal\n" +
                              "[3] Return");
            int animalId;
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Enter animal id");
                    animalId = SelectAnimal();
                    animals.RemoveAt(animalId);
                    break;
                case "2":
                    Console.WriteLine("Enter animal id");
                    animalId = SelectAnimal();
                    animals[animalId].Edit();
                    break;
                case "3":
                    isViewing = false;
                    break;
                default:
                    break;

            }

        }
    }

    public int SelectAnimal()
    {
        int animalId = 0;
        bool okResult = false;
        while (!okResult)
        {
            okResult = int.TryParse(Console.ReadLine(), out animalId);
            if (okResult && (animalId > 0 && animalId <= animals.Count))
            {
                break;
            }
            else
            {
                Console.WriteLine("Not an acceptable number");
                okResult = false;
            }
        }
        return animalId - 1;
    }

    public override string ToString()
    {
        string retval = "";
        if (animals.Count > 0)
        {
            retval = $"Conatains: {animals.Count} {animals[0].GetType().Name} \n Size: {Size} \n Popularity: {Popularity}";
        } else
        {
            retval = $"Contains: Emtpy \n Size: {Size} \n Popularity: {Popularity}";
        }
        return retval;
    }
}
