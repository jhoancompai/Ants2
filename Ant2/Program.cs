using System;

public class Program
{
    public static void Main()
    {
        string ants = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";
        int deadAnts = DeadAntCount(ants);
        Console.WriteLine("Número de hormigas muertas: " + deadAnts);
    }

    public static int DeadAntCount(string antString)
    {
        if (string.IsNullOrEmpty(antString))
        {
            return 0;
        }

        int aCount = 0, nCount = 0, tCount = 0;

        for (int i = 0; i < antString.Length; i++)
        {
            if (antString[i] == 'a')
            {
                if (i + 2 < antString.Length && antString[i + 1] == 'n' && antString[i + 2] == 't')
                {
                    i += 2; 
                }
                else
                {
                    aCount++;
                }
            }
            else if (antString[i] == 'n')
            {
                if (!(i > 0 && antString[i - 1] == 'a' && i + 1 < antString.Length && antString[i + 1] == 't'))
                {
                    nCount++;
                }
            }
            else if (antString[i] == 't')
            {
                if (!(i > 1 && antString[i - 2] == 'a' && antString[i - 1] == 'n'))
                {
                    tCount++;
                }
            }
        }

        return Math.Max(Math.Max(aCount, nCount), tCount);
    }
}
