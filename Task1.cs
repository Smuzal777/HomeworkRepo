namespace Lesson1
{
    internal class Task1
    {
        /*Написать программу, которая выводит на экран фразу "Hello, world!". После этого с клавиатуры должно быть считано имя пользователя (не забывайте про понятный ввод!) и выведена строка "Hello, имя_пользователя!".
         *
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string s = Console.ReadLine();
            Console.WriteLine($"Hello, {s}!");
        }
    }
}
/*
 * Введите имя:
Маша
Hello, Маша!

Введите имя:
Наташа
Hello, Наташа!

Введите имя:
Петя
Hello, Петя!
*/