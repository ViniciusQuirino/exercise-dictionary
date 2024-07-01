using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {

        Dictionary<string, int> cookies = new Dictionary<string, int>();

        string path = "/home/vinicius/Área de Trabalho/exercise-dictionary/in.txt";

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    int score = int.Parse(line[1]);
                    if (cookies.ContainsKey(name))
                    {
                        cookies[name] += score;
                    }
                    else
                    {
                        cookies[name] = score;
                    }
                }
                foreach (var item in cookies)
                {
                    Console.WriteLine(item.Key + ", " + item.Value);

                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

