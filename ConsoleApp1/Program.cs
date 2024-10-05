internal class Program
{
    static void Main()
    {
        // Ввод положительного вещественного числа
        double x = 27.3198;

        // Извлечение дробной части x
        double fractionalPart = x - Math.Truncate(x);

        // Преобразование дробной части в строку
        string fractionalPartStr = fractionalPart.ToString();

        // Удаление ведущего "0." из строки
        fractionalPartStr = fractionalPartStr.Substring(2);

        // Получение первого символа строки (т.е. первой цифры дробной части)
        char firstDigit = fractionalPartStr[0];

        // Преобразование символа в целое число
        int d = int.Parse(firstDigit.ToString());

        // Вывод результата
        Console.WriteLine("Первая цифра дробной части: " + d);
    }
}
