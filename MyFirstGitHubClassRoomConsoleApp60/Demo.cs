
public class Demo
{
    public string Navn { get; set; }
    public int Alder { get; set; }

    public Demo(string navn, int alder)
    {
        Navn = navn;
        Alder = alder;
    }
    public override string ToString()
    {
        return $"{Navn} {Alder}";
    }
}
 
