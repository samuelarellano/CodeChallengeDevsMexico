
string input1 = "abc";
string input2 = "abcdef";

Console.WriteLine(FormatOutput(SplitCharacters(input1))); // Output: ["ab", "c_"]
Console.WriteLine(FormatOutput(SplitCharacters(input2))); // Output: ["ab", "cd", "ef"]

Console.ReadLine();

static string[] SplitCharacters(string message)
{
    if (message.Length % 2 != 0)
    {
        message += "_";
    }

    return Enumerable.Range(0, message.Length / 2)
                     .Select(i => message.Substring(i * 2, 2))
                     .ToArray();
}

static string FormatOutput(string[] array)
{
    return $"[{string.Join(", ", array.Select(s => $"'{s}'"))}]";
}