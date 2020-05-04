using System;

namespace Vytautes
{
    class Chanel : Perfume
    {
        public string Smell { get; set; }
        public int Line { get; set; }

        private enum Smells
        {
            Vanilla,
            Anise,
            Vetiver,
            Grapefruit
        }

        public Chanel(int price, int volume, string name) : base(price, volume, name)
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
       

        public void PrintAbout()
        {
            Console.WriteLine("Perfumes CHANEL NO {0} are one and only. Its exclusive {1} smell will bring you delightful mood every day. Package details:", this.Line, GetSmell());
            PrintPerfumeBase();
        }

        ~Chanel()
        {
            Console.WriteLine("Cleaning up Chanel");
        }

    }
}
