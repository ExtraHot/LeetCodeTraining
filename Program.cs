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
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}

