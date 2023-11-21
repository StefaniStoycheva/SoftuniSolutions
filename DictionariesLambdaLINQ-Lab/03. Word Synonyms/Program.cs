int numberOfPairs = int.Parse(Console.ReadLine());

Dictionary<string, List<string>> synonims = new();

for (int i = 0; i < numberOfPairs; i += 1)
{
    string word = Console.ReadLine();
    string synonim = Console.ReadLine();

    if (synonims.ContainsKey(word))
    {
        synonims[word].Add(synonim);
    }
    else
    {
        synonims.Add(word, new List<string> { synonim });
    }
}
foreach (KeyValuePair<string, List<string>> pair in synonims)
{
    Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
}