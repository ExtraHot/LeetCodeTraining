//https://leetcode.com/problems/palindrome-number/
namespace LeetCodeTraining.Tasks;

static class Palindrome
{
    public static bool IsPalindrome(int x)
    {
        int original = x;
        int reversed = 0;

        if (x < 0)
            return false;
        while (x != 0)
        {
            reversed = reversed * 10 + (x % 10);
            x /= 10;
        }
        return reversed == original;
    }
}
