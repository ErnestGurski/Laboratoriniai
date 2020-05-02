using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class MainClass
{
    public static List<studentas> studentai = new List<studentas>();

    public static void Menu()
    {
        while (true)
        {
            Console.WriteLine("Pasirinkite norimą funkciją:");
            Console.WriteLine("1. Studento pridėjimas rankiniu būdu");
            Console.WriteLine("2. Studentų pridėjimas iš failo");
            Console.WriteLine("3. Studentų sąrašas");
            Console.WriteLine("4. Baigti darbą");

            switch (Console.ReadLine())
            {
                case "1":
                    try
                    {
                        Console.WriteLine("Įveskite studento vardą, pavardę, n.d. pažymius ir egzamino rezultatą");
                        var data = Console.ReadLine().Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                        List<double> balai = new List<double>();
                        for (int i = 2; i < data.Length - 1; i++)
                        {
                            balai.Add(double.Parse(data[i]));
                        }

                        double egz = double.Parse(data.Last());
                        studentai.Add(new studentas(data[0], data[1], egz, balai));
                        studentai = studentai.OrderBy(o => o.vardas).ToList();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Įvyko klaida: " + ex.Message);
                    }
                    break;
                case "2":
                    try
                    {
                        string[] lines = File.ReadAllLines("studentai.txt");
                        Console.WriteLine("Nuskaitomas dokumentas");
                        foreach (var line in lines)
                        {
                            var data = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                            List<double> balai = new List<double>();
                            for (int i = 2; i < data.Length - 1; i++)
                            {
                                balai.Add(double.Parse(data[i]));
                            }

                            double egz = double.Parse(data.Last());
                            studentai.Add(new studentas(data[0], data[1], egz, balai));
                        }
                        Console.WriteLine("Dokumentas nuskaitytas");
                        studentai = studentai.OrderBy(o => o.vardas).ToList();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Klaida nuskaitant failą: " + ex.Message);
                    }
                    break;
                case "3":
                    try
                    {
                        Console.WriteLine("{0} {1, 10} {2, 10} {3, 10}", "Pavarde", "Vardas", "Galutinis (vid.)", "Galutinis (med.)");
                        Console.WriteLine("-----------------------------------------------------");
                        foreach (var stud in studentai)
                        {
                            Console.WriteLine("{0} {1, 10} {2, 10} {3, 10}", stud.pavarde, stud.vardas, stud.galutinis.ToString("0.00"), stud.galutinisMed.ToString("0.00"));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Įvyko klaida: " + ex.Message);
                    }
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
    {
        Menu();
    }


}