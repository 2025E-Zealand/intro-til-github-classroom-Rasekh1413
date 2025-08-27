using System.Reflection;

public class Bil
{
    
    public string Bilnavn { get; set; }

    public int Bilår { get; set; }
    
    public string Biltype { get; set; }


    public Bil(string bilnavn, int bilår, string biltype)
    {
        Bilnavn = bilnavn;
        Bilår = bilår;
        Biltype = biltype;
    }

    public override string ToString()
    {
        return $"{Bilnavn} {Biltype} {Bilår}";
    }

}

