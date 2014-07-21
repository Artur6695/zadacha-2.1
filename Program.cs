using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную длину предложения (кол-во слов)");
            string s = Console.ReadLine();
            int k = int.Parse(s);

            Console.WriteLine("\nВведите предложение!");
            string sentance = Console.ReadLine();
            
            Predlojenie p = new Predlojenie(k, sentance);

            if (p._words.Length > p._maxWords)
                Console.WriteLine("Количество слов в предложении больше максимально возможного");
            else
            {
                Console.WriteLine("Кол-во слов в предложении = {0}", p._words.Length);
                Console.WriteLine("Кол-во знаков препинания в предложении = {0}", p._chars);

                Console.WriteLine("\nСлова в предложении в обратном порядке \n{0}", p.ReverseSentance());

                Console.WriteLine("\nВведите индекс слова в предложении, которое надо найти");
                s = Console.ReadLine();
                int index = int.Parse(s);

                Console.WriteLine("\nСлово с индексом {0} - {1}", index, p.SearchWord(index - 1));
            }

            Console.ReadKey();
        }
    }
}
