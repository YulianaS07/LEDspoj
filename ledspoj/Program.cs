using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<string> dane = new List<string>();
        while (true)
        {
            var linia = Console.ReadLine();

            if (string.IsNullOrEmpty(linia))
            {
                break;
            }
            dane.Add(linia);
        }

        for (int poz = 0; poz < dane.Count - 1; poz += 3)
        {
            string wejscie = dane[poz];
            string wejscie1 = dane[poz + 1];
            string wejscie2 = dane[poz + 2];

            Dictionary<string, string[]> ledLiczby = new Dictionary<string, string[]> {
            {"0", new string[] {" _ ", "| |", "|_|"}},
            {"1", new string[] {"   ", "  |", "  |"}},
            {"2", new string[] {" _ ", " _|", "|_ "}},
            {"3", new string[] {" _ ", " _|", " _|"}},
            {"4", new string[] {"   ", "|_|", "  |"}},
            {"5", new string[] {" _ ", "|_ ", " _|"}},
            {"6", new string[] {" _ ", "|_ ", "|_|"}},
            {"7", new string[] {" _ ", "  |", "  |"}},
            {"8", new string[] {" _ ", "|_|", "|_|"}},
            {"9", new string[] {" _ ", "|_|", "  |"}}
        };

            string wynik = "";

            int nr = wejscie.Length / 3;

            string[] wyjscie = new string[nr];
            string[] wyjscie1 = new string[nr];
            string[] wyjscie2 = new string[nr];

            for (int i = 0; i < wejscie.Length; i += 3)
            {
                wyjscie[i / 3] = $"{wejscie[i]}{wejscie[i + 1]}{wejscie[i + 2]}";
                wyjscie1[i / 3] = $"{wejscie1[i]}{wejscie1[i + 1]}{wejscie1[i + 2]}";
                wyjscie2[i / 3] = $"{wejscie2[i]}{wejscie2[i + 1]}{wejscie2[i + 2]}";
            }

            for (int i = 0; i < wejscie.Length; i += 3)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (ledLiczby[j.ToString()][0] == wyjscie[i / 3] && 
                        ledLiczby[j.ToString()][1] == wyjscie1[i / 3] && 
                        ledLiczby[j.ToString()][2] == wyjscie2[i / 3])
                    {
                        wynik += j.ToString();
                    }
                }
            }

            Console.WriteLine(wynik);
        }
    }
}