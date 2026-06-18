public class Program
{
    static void Main()
    {

        string inputString = "aabbcdde";

        Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

        foreach(char ch in inputString)
        {
            if (keyValuePairs.ContainsKey(ch))
            {
                keyValuePairs[ch]++;
            }
            else
            {
                keyValuePairs[ch] = 1;
            }
        }
        foreach(char ch in inputString) {
            if (keyValuePairs[ch] == 1)
            {
                Console.WriteLine("first non repeating character is = " + ch);
                break;
            }
        }
    }
}