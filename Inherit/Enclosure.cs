class Enclosure
{
    public List<Animal> animals {  get; set; }
    public int Size { get; set; }
    public int Popularity { get; set; }
    public Enclosure()
    {
        animals = new List<Animal>();
    }

    public override string ToString()
    {
        string retval = "";
        // fixa utskriften 
        if (animals != null)
        {
            retval = $"Conatains: {animals.Count} {animals[0].GetType().Name} \n Size: {Size} \n Popularity: {Popularity}";
        } else
        {
            retval = $"Contains: Emtpy \n Size: {Size} \n Popularity: {Popularity}";
        }
        return retval;
    }
}
