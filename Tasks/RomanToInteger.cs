//https://leetcode.com/problems/roman-to-integer/
namespace LeetCodeTraining.Tasks;

public static class RomanToInteger
{
    public static int RomanToInt(string s)
    {
        int result = 0;
        string previous = " ";

        Dictionary<string, int> roman = new Dictionary<string, int>();
        roman.Add("I", 1);
        roman.Add("V", 5);
        roman.Add("X", 10);
        roman.Add("L", 50);
        roman.Add("C", 100);
        roman.Add("D", 500);
        roman.Add("M", 1000);
        roman.Add("IV", 4);
        roman.Add("IX", 9);
        roman.Add("XL", 40);
        roman.Add("XC", 90);
        roman.Add("CD", 400);
        roman.Add("CM", 900);
        foreach (var elem in s)
        {
            if (roman.ContainsKey(previous + elem))
            {
                result -= roman[previous];
                result += roman[previous + elem];
            }
            else
            {
                result += roman[elem.ToString()];
            }
            previous = elem.ToString();
        }

        return result;
    }
}
