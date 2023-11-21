using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            var lines = File.ReadAllLines("INPUT.TXT");
            int N = int.Parse(lines[0]);
            var talkativeness = lines[1].Split(' ').Select(int.Parse).ToArray();

            Array.Sort(talkativeness);

            int minChattiness = int.MaxValue;
            for (int i = 1; i < N; i++)
            {
                minChattiness = Math.Min(minChattiness, talkativeness[i] - talkativeness[i - 1]);
            }

            File.WriteAllText("OUTPUT.TXT", minChattiness.ToString());
        }
        catch (FormatException fe)
        {
            Console.WriteLine($"Format exception: {fe.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"General exception: {ex.Message}");
        }
    }
}
