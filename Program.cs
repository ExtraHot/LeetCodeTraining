using LeetCodeTraining.Tasks;

namespace LeetCodeTraining;

public static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an task 1 - Palindrome");
        string? choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.WriteLine(Palindrome.IsPalindrome(120).ToString());
                break;
            case "2":
                Console.WriteLine(RomanToInteger.RomanToInt("MCMXCIV"));
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
