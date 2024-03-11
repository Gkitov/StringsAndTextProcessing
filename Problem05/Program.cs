using System;

class Program
{
    static void Main()
    {
        
       
        string inputString = Console.ReadLine();

        
        foreach (char character in inputString)
        {
            
            if (char.IsDigit(character))
            {
                Console.Write(character);
            }
        }

        Console.WriteLine();

        foreach (char character in inputString)
        {
            
            if (char.IsLetter(character))
            {
                Console.Write(character);
            }
        }

        Console.WriteLine();

        foreach (char character in inputString)
        {
         
            if (!char.IsDigit(character) && !char.IsLetter(character))
            {
                Console.Write(character);
            }
        }

        Console.WriteLine(); 
    }
}

