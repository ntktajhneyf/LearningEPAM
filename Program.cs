using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Reflection.Metadata;
using System.Xml.Schema;

public class searchStudent
{
    public static void Main()
    {

        string[] studantName = { "Smith", "Olaf", "Jon", "Auron", "Melisa", "Cirkul", "Shmon", "Arnold" };

        Console.WriteLine("Write student name");
        string newName = Console.ReadLine();

        bool isNAmeFound = CheckNAmeArrey(studantName, newName);
        Console.WriteLine(isNAmeFound ? $"Студент {newName} присутній" : "False");


        static bool CheckNAmeArrey(string[] studantName, string newName)
        {
            foreach (string name in studantName)
            {
                if (name == newName)
                {
                    return true;
                }



            }
            return false;
        }

        // foreach (string Name in studantName)
        // {
        //     if (Name == newName)
        //     {
        //         Console.WriteLine($"Student {newName} was in clasroom");
        //         break;
        //     }
        //     if ()
        //     {

        //         Console.WriteLine($"The student {newName} is absent from class");
        //     }
        // }


    }



}



