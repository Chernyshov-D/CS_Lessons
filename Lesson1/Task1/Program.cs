// Напишите программу, которая на вход принимает число и 
// выдает его квадрат (число умноженное на само себя).


//Функция на вход получает параметр, на выходе введенное с консоли значение
int Prompt(string message){
    System.Console.Write(message); // Выводит сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Конвертация строки в число
    return result; // Возвращает результат
}

int value = Prompt("Введите значение >"); // Вводим значение
int result = value * value; // Вычисляем квадрат
System.Console.WriteLine($"Квадрат числа {value} равен {result}"); // Вывод результата