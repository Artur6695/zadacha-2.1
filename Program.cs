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
            Console.WriteLine("Введите максимальную длину предложения (кол-во символов)");
            // Считываем значение из консоли и преобразовываем значение в число
            string s = Console.ReadLine();
            int k = int.Parse(s);

            Console.WriteLine("\nВведите предложение!");
            // Считываем предложение и записываем в строковую переменную sentance
            string sentance = Console.ReadLine();
            
            // Создаём экземпляр нашего класса "Предложение"
            Predlojenie p = new Predlojenie(k, sentance);

            // Проверяем, не превышает ли кол-во введённых символов максимально возможную длину предложения
            // и если не превышает, то считаем кол-во слов/знаков препинания в предложении,
            // выводим предложение со словами в обратном порядке, и исчем слово по введённому индексу
            if (sentance.Length > p._maxChars)
                Console.WriteLine("\nДлина введённого предложения больше максимально возможной длины предложения");
            else
            {
                Console.WriteLine("Кол-во слов в предложении = {0}", p._words.Length);
                Console.WriteLine("Кол-во знаков препинания в предложении = {0}", p._chars);

                Console.WriteLine("\nСлова в предложении в обратном порядке \n{0}", p.ReverseSentance());

                Console.WriteLine("\nВведите индекс слова в предложении, которое надо найти");
                s = Console.ReadLine();
                int index = int.Parse(s);

                Console.WriteLine("\nСлово с индексом {0} - {1}", index, p.SearchSentanse(index - 1));
            }

            // Эта строчка нужна, чтобы консоль закрывалась при нажатии какой либо клавиши, по завершении работы с программой
            Console.ReadKey();
        }
    }
}
