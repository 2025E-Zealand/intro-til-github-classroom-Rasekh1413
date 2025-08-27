// See https://aka.ms/new-console-template for more information


Console.WriteLine("Den er et eksampel");


Bil ejebil = new Bil("BMW", 2009, "E60 - 5-Series");
Demo Demo1 = new Demo("Rasekh", 20);
Demo Demo2 = new Demo("Elaf", 20);


Console.WriteLine($"{Demo1.Navn} er {Demo1.Alder} " + "år," + " og han har en bil, der hedder: " + $"{ejebil}");
Console.WriteLine($"{Demo2.Navn} er {Demo2.Alder} " + "år," + " og hun har ikke en bil, som " +  $"{Demo1.Navn} " + "har, der hedder: " + $"{ejebil}");

