
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

            switch (Console.ReadLine())
            {
                case "1":
                    try
                    {
                        Console.WriteLine("Įveskite studento: vardą, pavardę, namų darbų pažymius ir egzo rezultatą");
                        var data = Console.ReadLine().Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                        List<double> point = new List<double>();
                        for (int i = 2; i < data.Length - 1; i++)
                        { point.Add(double.Parse(data[i])); }

                        double egz = double.Parse(data.Last());
                        students.Add(new student(data[0], data[1], egz, point));
                        students = students.OrderBy(o => o.name).ToList();
                    }
                    catch (Exception ex)
                    {  Console.WriteLine("Įvyko klaida: " + ex.Message); }
                    break;
                case "2":
                    try
                    {
                        string[] lines = File.ReadAllLines("studentai.txt");
                        Console.WriteLine("Duomenys nuskaitomi");
                        foreach (var line in lines)
                        {
                            var data = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                            List<double> point = new List<double>();
                            for (int i = 2; i < data.Length - 1; i++)
                            {  point.Add(double.Parse(data[i])); }

                            double egz = double.Parse(data.Last());
                            students.Add(new student(data[0], data[1], egz, point));
                        }
                        Console.WriteLine("Duomenys nuskaitytas");
                        students = students.OrderBy(o => o.name).ToList();
                    }
                    catch (Exception ex)
                    { Console.WriteLine("Klaida nuskaitant duomenys iš failo: " + ex.Message); }
                    break;
                case "3":
                    try
                    {
                        Console.WriteLine("{0} {1, 10} {2, 10} {3, 10}", "surname", "name", "sum (vid.)", "sum (med.)");
                        Console.WriteLine("-----------------------------------------------------");
                        foreach (var stud in students)
                        {
                            Console.WriteLine("{0} {1, 10} {2, 10} {3, 10}", stud.surname, stud.name, stud.sum.ToString("0.00"), stud.sumMed.ToString("0.00"));
                        }
                    }
                    catch (Exception ex)
                    { Console.WriteLine("Klaida!!!: " + ex.Message); }
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Tokio pasirinkimo nėra");
                    break;
            }
            Console.ReadLine();
        }
    }


    public static void Main(string[] args)
    
    { Menu(); }


}

class student
{
    public string name { get; set; }
    public string surname { get; set; }
    public double egzorez { get; set; }
    public double sum
    {
        get
        { return this.vid * 0.3 + this.egzorez*0.7;  }
    }

    public double sumMed
    {
        get
        {  return this.point[this.point.Count / 2] * 0.3 + this.egzorez*0.7;  }
    }
    public double vid
    {
        get
        {
            double temp = 0;
            foreach (var value in this.point)
            {
                temp += value;
            }
            return temp / this.point.Count;
        }
    }

    public List<double> point = new List<double>();


    public student(string name, string surname, double egzorez, List<double> point)
    {
        this.name = name;
        this.surname = surname;
        this.egzorez = egzorez;
        this.point = new List<double>(point);
        this.point.Sort();
    }


}
