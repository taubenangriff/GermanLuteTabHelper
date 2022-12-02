// See https://aka.ms/new-console-template for more information

Dictionary<String, String> Values = new()
{
    { "1", "A string" },
    { "2", "D string" },
    { "3", "F# string" },
    { "4", "B string" },
    { "5", "high E string" },
    { "7", "2nd string 5th fret" },
    { "9", "1st string 5th fret" },
    { "A", "low E string" },
    { "a", "low Bb" },
    { "B", "low F" },
    { "b", "middle Eb" },
    { "C", "low F#" },
    { "c", "middle G" },
    { "D", "low G" },
    { "d", "middle C" },
    { "E", "low G#" },
    { "F", "low A" },
    { "f", "low B" },
    { "G", "low Bb" },
    { "g", "middle E" },
    { "H", "low B" },
    { "h", "middle G#" },
    { "I", "low C" },
    { "i", "middle C#" },
    { "k", "high F#" },
    { "l", "low C" },
    { "m", "middle F" },
    { "n", "middle A" },
    { "o", "middle D" },
    { "p", "high G" },
    { "q", "low C#" },
    { "r", "middle F#" },
    { "s", "middle Bb" },
    { "t", "middle D#" },
    { "v", "high G#" },
    { "x", "middle D" },
    { "y", "middle G" },
    { "z", "middle B" }
};

Console.WriteLine("Hello, World!");

String fuck; 
while((fuck = Console.ReadLine()) != "Exit")
{
    if (Values.TryGetValue(fuck, out var result))
    {
        Console.WriteLine($"Note for {fuck} is {result}");
    }
    else
    {
        Console.WriteLine($"no result for {fuck}");
    }
}
