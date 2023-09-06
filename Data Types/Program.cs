using System;

namespace Data_Types
{
    internal class Program
    {
        //static void DoSomething()
        //{
        //    int result;
        //    Console.WriteLine(result);

        //}
        static void Main(string[] args)
        {
            //Неявно типизированные переменные - тип определяется с помощью инициализатора
            var name = "Дина";
            var age = 26;
            var isProgrammer = true;

            // Получить тип переменных
            Type nameType = name.GetType();
            Type ageType = age.GetType();

            Console.WriteLine("Тип name: {0}", nameType);
            Console.WriteLine($"Тип age {ageType}");
            Console.WriteLine("Тип isProgrammer {0}", isProgrammer.GetType());

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
