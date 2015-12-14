using System; // Использую пространство имён 'System'

class Animal // Определяем класс 'Animal'
{
    static void Main() // Определяем метод 'Main' - точку входа в программу
    {
        string myVariable = "...идёт работа консоли"; // Создание переменной типа 'string' с текстовыми данными в ней
        Console.WriteLine(myVariable);
        Console.WriteLine(myVariable); // Повторяем инструкцию несколько раз.
        Console.WriteLine(myVariable); // Вывод на консоль
        Console.Read(); // Перехват информации введённой с клавиатуры
    }
}