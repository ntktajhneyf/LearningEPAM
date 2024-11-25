using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Reflection.Metadata;
using System.Xml.Schema;

public class ArreyExample
{
    public static void Main()
    {
        var filmografphy = new int[10];
        filmografphy[0] = 10;
        filmografphy[1] = 7;
        filmografphy[2] = 23;

        for (int i = 3; i < 10; i++)
        {
            Console.WriteLine($"The number of movies with superhiro #{i + 1} is: ");
            filmografphy[i] = Convert.ToInt32(Console.ReadLine());
        }

        int totalMovies = 0;
        foreach (int num in filmografphy)
        {
            totalMovies += num;
        }

        Console.WriteLine($"The total number of movies with all superheroes: {totalMovies}");

        int min = filmografphy[0];
        for (int i = 0; i < filmografphy.Length; i++)
        {
            if (filmografphy[i] < min)
            {
                min = filmografphy[i];
            }
        }
        Console.WriteLine($"The smallest filmography consist of {min} movies");

    }



}



