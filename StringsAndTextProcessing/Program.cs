string input = Console.ReadLine();

while (input != "end")
{
    string reversed = string.Join("", input.Reverse().ToArray());

    Console.WriteLine(input + " = " + reversed);

    input = Console.ReadLine();
}
