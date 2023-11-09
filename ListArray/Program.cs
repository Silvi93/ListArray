using System.ComponentModel.Design;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)


    {
        List<int> oddNumbers = new List<int>();
        List<int> evenNumbers = new List<int>();

        Console.WriteLine("Enter numbers: ");

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

          if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
                else
                {
                    oddNumbers.Add(number);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number or type 'exit' to stop.");
            }
        }

        Console.WriteLine("Odd Numbers:");
        PrintNumbers(oddNumbers);

        Console.WriteLine("Even Numbers:");
        PrintNumbers(evenNumbers);
    }

    static void PrintNumbers(List<int> numbers)
    {
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
        
        }
    



//List<string> socialNetworks = new List<string>();


//socialNetworks.Add("Youtube");
//socialNetworks.Add("facebook");
//socialNetworks.Add("Instagram");
//socialNetworks.Add("Tiktok");

//socialNetworks.Insert(1, "vyy");

//Console.WriteLine();
//foreach (string asocialNetwork in socialNetworks)
//{
//    Console.WriteLine(asocialNetwork);

//}