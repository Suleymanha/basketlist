using System;

namespace basketlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(0.175, 0.1, 0.3, 'C');
            Apple apple1 = new Apple(0.32, 0.2, 0.5,'E');
            Pineapple pineapple = new Pineapple(0.45, 0.21, 0.5, 'B');
            Pineapple pineapple1 = new Pineapple(0.65, 0.48, 0.8, 'A');
            Lemon lemon = new Lemon(0.124,0.2,0.14,'D');
            Lemon lemon1 = new Lemon(0.24,0.4,0.15,'E');

            BasketList<Apple> applelist = new BasketList<Apple>();
            applelist.Add(apple);
            applelist.Add(apple1);

            Console.WriteLine(applelist.Count);
            foreach (var item in applelist.GetArray())
            {
                Console.WriteLine(apple.Sodium);
            }
            BasketList<Pineapple> Pineapplelist = new BasketList<Pineapple>();
            Pineapplelist.Add(pineapple);
            Pineapplelist.Add(pineapple1);

            Console.WriteLine(Pineapplelist.Count);
            foreach (var item in Pineapplelist.GetArray())
            {
                Console.WriteLine(pineapple.Vitamin);
            }
            BasketList<Lemon> lemonlist = new BasketList<Lemon>();
            lemonlist.Add(lemon);
            lemonlist.Add(lemon1);

            Console.WriteLine(lemonlist.Count);

            foreach (var item in lemonlist.GetArray())
            {
                Console.WriteLine(lemon1.Protein);
            }
        }
    }
}
