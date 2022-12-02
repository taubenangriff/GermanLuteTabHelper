Dictionary<String?, String> TabNotes = new()
{
    { "1", "A string" },
    { "2", "D string" },
    { "3", "F# string" },
    { "4", "B string" },
    { "5", "high E" },
    { "7", "high E (2nd string)" },
    { "9", "high A" },
    { "A", "low E" },
    { "a", "low Bb" },
    { "a-", "middle Eb"},
    { "B", "low F" },
    { "b", "low Eb" },
    { "b-", "middle A"},
    { "C", "low F#" },
    { "c", "middle G" },
    { "c-", "middle C"},
    { "D", "low G" },
    { "d", "middle C" },
    { "d-", "high F"},
    { "E", "low G#" },
    { "e", "high F"},
    { "e-", "high Bb"},
    { "F", "low A" },
    { "f", "low B" },
    { "f-", "middle E"},
    { "G", "low Bb" },
    { "g", "middle E" },
    { "g-", "middle A"},
    { "H", "low B" },
    { "h", "middle G#" },
    { "h-", "middle C#"},
    { "I", "low C" },
    { "i", "middle C#" },
    { "i-", "high F#"},
    { "k", "high F#" },
    { "l", "low C" },
    { "l-", "middle F"},
    { "m", "middle F" },
    { "m-", "middle Bb"},
    { "n", "middle A" },
    { "n-", "middle D"},
    { "o", "middle D" },
    { "o-", "high G"},
    { "p", "high G" },
    { "p-", "high C"},
    { "q", "low C#" },
    { "q-", "middle F#"},
    { "r", "middle F#" },
    { "r-", "middle B"},
    { "s", "middle Bb" },
    { "s-", "middle Eb"},
    { "t", "middle D#" },
    { "t-", "high G#"},
    { "v", "high G#" },
    { "v-", "high C#"},
    { "x", "middle D" },
    { "y", "middle G" },
    { "z", "middle B" }
};

String? input; 
while((input = Console.ReadLine()) != "Exit")
{
    if (input is null || input == "")
    {
        Console.WriteLine("Invalid input!");
        continue;
    }; 

    var input_vals = input.Split(" ").Select(x => x.Trim()).Where(x => x != "");
    var wrong_vals = input_vals.Where(x => !TabNotes.ContainsKey(x));
    if (wrong_vals.Count() > 0)
    {
        Console.WriteLine($"no result for {String.Join(", ", wrong_vals)}! Only valid notes are displayed in the result:");
    }

    var right_vals = input_vals.Where(x => !wrong_vals.Contains(x));
    var conv_vals = right_vals.Select(x =>
    {
        return TabNotes.GetValueOrDefault(x);
    });

    Console.WriteLine("Notes: [Tab] -> [Note]");
    for (int i = 0; i < right_vals.Count(); i++)
    {
        Console.WriteLine($"{right_vals.ElementAt(i)} -> {conv_vals.ElementAt(i)}");
    }
    Console.WriteLine();
}
