using System.IO;
using System;

class Program
{
    static void Main()
    {
        // Read in every line in the file.
        using (StreamReader reader = new StreamReader("input.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                int number = Convert.ToInt32(line);
                if(number%2 == 0) {
                    Console.WriteLine("Even");
                }
                else {
                    Console.WriteLine("Odd");
                }
            }
        }
    }
}
