Dictionary<String?, String> Values = new()
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

String? input; 
while((input = Console.ReadLine()) != "Exit")
{
    if (Values.TryGetValue(input, out var result))
    {
        Console.WriteLine($"Note for {input} is {result}");
    }
    else
    {
        Console.WriteLine($"no result for {input}");
    }
}
