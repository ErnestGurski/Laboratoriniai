using System;

namespace Vytautes
{
    class Dior : Perfume
    {
        public string Smell { get; set; }

        private enum Smells
        {
            Rose,
            Cinaom,
            Oak,
            strawberry
        }

        public Dior(int price, int volume, string name) : base(price, volume, name)
        {
            this.Smell = Smell;
        }

        public static void GetAvailableSmells()
        {
            var smells = Enum.GetValues(typeof(Smells));
            Console.WriteLine("Available smells:");
            foreach (var smell in smells)
            {
                Console.Write(smell.ToString() + " ");
            }
        }

        public override string GetSmell()
        {
            return this.Smell;
        }

        ~Dior()
        {
            Console.WriteLine("Cleaning up Dior");
        }

    }
}
