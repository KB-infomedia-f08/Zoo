using Newtonsoft.Json;
//using System.Text.Json;

class Zoo
{
    private Enclosure[] enclosures;

    public Zoo()
    {
        if (File.Exists("zoo.json"))
        {
            StreamReader sr = File.OpenText("zoo.json");
            string jsonData = sr.ReadToEnd();
            var serializerSettings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            enclosures = JsonConvert.DeserializeObject<Enclosure[]>(jsonData, serializerSettings);
            
            //enclosures = JsonSerializer.Deserialize<Enclosure[]>(jsonData);

            sr.Close();
        }
        else
        {
            //Set amount of enclousers in Zoo
            enclosures = new Enclosure[3];
            for (int i = 0; i < enclosures.Length; i++)
            {
                enclosures[i] = new Enclosure();
            }
            //Add animals to enclousures
            enclosures[0].animals = [new Pinguin("Bobby",10, 90,true),
                                 new Pinguin("Zoey", 4, 75, false),
                                 new Pinguin("Mira", 5, 40, false)];
        }
        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            PrintEnclosures();
            Console.WriteLine("[1] View an enclousre \n" +
                              "[2] Add an animal \n" +
                              "[3] Exit \n");
            switch (Console.ReadLine())
            {
                case "1":
                    int enclosureId = SelectEnclosure();
                    enclosures[enclosureId].View();
                    break;
                case "2":
                    AddAnimal();
                    break;
                case "3":
                    StreamWriter sw = File.CreateText("zoo.json");
                    var serializerSettings = new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    };
                    string data = JsonConvert.SerializeObject(enclosures, serializerSettings);
                    
                    //string data = JsonSerializer.Serialize<Enclosure[]>(enclosures);
                    sw.Write(data);
                    sw.Close();
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
        

        
    }
    public void PrintEnclosures()
    {
        foreach(Enclosure enclosure in enclosures)
        {
            Console.WriteLine(enclosure.ToString());
        }
    }
    //*Gör valet av djur dynamisk
    public void AddAnimal()
    {
        Console.WriteLine("Select type of animal\n[1] Pinguin\n[2] Lion");
        Animal temp = null;
        switch (Console.ReadLine())
        {
            case "1":
                temp = new Pinguin();
                break;
            case "2":
                temp = new Lion();
                break;
        }
        if(temp != null)
        {
            enclosures[SelectEnclosure()].animals.Add(temp);
        }
    }

    public int SelectEnclosure()
    {
        Console.Write("Select enclosure ");
        for (int i = 0; i < enclosures.Length; i++)
        {
            Console.Write($"[{i + 1}] ");
        }
        int enclosureId = 0;
        bool okResult = false;
        while (!okResult)
        {
            okResult = int.TryParse(Console.ReadLine(), out enclosureId);
            if (okResult && (enclosureId > 0 && enclosureId <= 3))
            {
                break;
            }
            else
            {
                Console.WriteLine("Not an acceptable number");
                okResult = false;
            }
        }
        return enclosureId - 1;
    }

    /*
     * Lista på funktioner att lägga till
     * ta bort djur
     * Ladda in och spara djur och inhängnader till fil
     * 
     */
}
