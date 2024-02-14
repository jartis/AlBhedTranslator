using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // If args[0] is '-a', convert AlBhed to English. Otherwise, English to AlBhed.
        string A2E = "ypltavkrezgmshubxncdijfqow";

        int direction = 1;

        var argumentList = args.ToList();

        if (argumentList[0].ToLower() == "-a") { 
            direction = 0;
            argumentList.RemoveAt(0);
        }

        string input = string.Join(" ", argumentList);
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLetter(input[i]))
            {
                string lower = input[i].ToString().ToLower();
                int idx = 0;
                if (direction == 1)
                {
                    idx = lower[0] - 'a';
                    output.Append(A2E[idx]);
                }
                else
                {
                    idx = A2E.IndexOf(lower);
                    output.Append((char)('a' + idx));
                }
            }
            else
            {
                output.Append(input[i]);                 
            }
        }
        Console.WriteLine(output.ToString());
    }
}