
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class MainClass
{
    public static List<student> students = new List<student>();

    public static void Menu()
    {
        while (true)
        {
            Console.WriteLine("Pasirinkite norimą funkciją:");
            Console.WriteLine("1. Pridėti studenta pačiam");
            Console.WriteLine("2. Pridėti studentą iš failo");
            Console.WriteLine("3. Studentų sąrašas");
            Console.WriteLine("4. Baigti darbą");

        }
    }


    public static void Main(string[] args)
    {
        Menu();
    }


}
