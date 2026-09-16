class Zoo
{
    private Enclosure[] enclosures;

    public Zoo()
    {
        //Set amount of enclousers in Zoo
        enclosures = new Enclosure[3];
        for(int i = 0; i < enclosures.Length; i++)
        {
            enclosures[i] = new Enclosure();
        }
        //Add animals to enclousures
        enclosures[0].animals = [new Pinguin("Bobby",10, 90,true),
                                 new Pinguin("Zoey", 4, 75, false),
                                 new Pinguin("Mira", 5, 40, false)];
        PrintEnclosures();
    }
    public void PrintEnclosures()
    {
        foreach(Enclosure enclosure in enclosures)
        {
            Console.WriteLine(enclosure.ToString());
        }
    }
    //*Gör valet av djur dynamisk
    //Gör idiot säker 
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
            //optimisera valet av inhängnader
            Console.WriteLine("Select enclosure [1] [2] [3]");
            switch (Console.ReadLine()) 
            {
                case "1":
                    enclosures[0].animals.Add(temp);
                    break;
                case "2":
                    enclosures[2].animals.Add(temp);
                    break;
                case "3":
                    enclosures[3].animals.Add(temp);
                    break;
            }
        }
    }

    /*
     * Lista på funktioner att lägga till
     * ta bort djur
     * redigera djur
     * se specifika djur i en detaljerad vy (lägg i Enclosure.cs)
     * 
     * Ladda in och spara djur och inhängnader till fil
     * 
     * Lägg till ett till djur
     */
}
