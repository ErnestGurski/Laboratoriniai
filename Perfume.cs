using System;

namespace Vytautes
{
    class Perfume
    {
        public int Price { get; set; }
        public int Volume { get; set; }
        public string Name { get; set; }

        public Perfume(int price, int volume, string name)
        {
            this.Price = price;
            this.Volume = volume;
            this.Name = name;
        }

        public void PrintPerfumeBase()
        {
            Console.WriteLine("{0} of quantity {1} ml is priced at {2}", this.Name, this.Volume, this.Price);
        }

        public virtual string GetSmell()
        {
            return "No smell";
        }

        ~Perfume()
        {
            Console.WriteLine("Cleaning up perfumes");
        }
    }
}
