// See https://aka.ms/new-console-template for more information

using Task6_Method_in_Class;

int getNumberOne, getNumberTwo;
double getDoubleOne;
StartProgramm();
string answerTask;
void StartProgramm()
{
    Methods methods = new Methods();
    Console.WriteLine("Введите номер задания и нажмите Enter.");
    Console.WriteLine("1   Вывести все квадраты натуральных чисел, не превосходящие данного числа N.");
    Console.WriteLine("2   Вывести на экран кубы чисел от A до B, которые вводит пользователь.");
    Console.WriteLine(
        "3   Написать программу на языке C#, которая возводит число в целочисленную степень. Число и степень вводятся с клавиатуры.");
    Console.WriteLine("4   Используя цикл написать программу, которая выводит на экран таблицу значений функции " +
                      "y = 5 - x2/2 на отрезке [-5; 5] с шагом 0.5.");
    Console.WriteLine("5   Поиск факториала.");
    Console.WriteLine(
        "6   Вывести на экран ряд чисел Фибоначчи, состоящий из N элементов. Значение N вводится с клавиатуры.");
    Console.WriteLine("7   Проверка гипотезы Сиракуз.");
    Console.WriteLine("8   Извлечение цифр числа.");
    Console.WriteLine("9   Выход из программы.");


    do
    {
        getNumberOne = methods.GetOneIntKeyboard();
        if (getNumberOne <= 9)
        {
            break;  
        }
        Console.WriteLine("Некорректное число.");
    }
    while (true) ;
    
    switch (getNumberOne)
    {
        case (1):
            methods.Print("Task_4_1. Вывести все квадраты натуральных чисел, не превосходящие данного числа N.");
            methods.Print("Введите предел.");
            getNumberOne = methods.GetOneIntKeyboard();
            methods.Print(methods.GetSquareNumber(getNumberOne));
            break;
        
        case (2):
            methods.Print("Task_4_2. Вывести на экран кубы чисел от A до B, которые вводит пользователь.");
            methods.Print("A: ");
            getNumberOne = methods.GetOneIntKeyboard();
            methods.Print("B: ");
            getNumberTwo = methods.GetOneIntKeyboard();
            methods.Print(methods.GetNumberCubed(getNumberOne, getNumberTwo));
            
            break;
        case (3):
            methods.Print("Task_4_3 Написать программу на языке C#, которая возводит число в целочисленную степень. Число и степень вводятся с клавиатуры.");
            methods.Print("Число: ");
            getDoubleOne = methods.GetOneDoubleKeyboard();
            methods.Print("Степень: ");
            getNumberOne = methods.GetOneIntKeyboard();
            methods.Print(methods.GetExponentiation(getDoubleOne,getNumberOne));
            break;
        case (4):
            methods.Print("Используя цикл написать программу, которая выводит на экран таблицу значений функции " +
                          "y = 5 - x2/2 на отрезке [-5; 5] с шагом 0.5.");
            methods.Print(" X      Y");
            methods.Print(methods.GetTableFunction());
            
            break;
        case (5):
            methods.Print("Введите число от 0 до 255: ");
            methods.Print(methods.GetFactorial(methods.GetOneByteKeyboard()));
            break;
        case (6):
            methods.Print("Вывести на экран ряд чисел Фибоначчи, состоящий из N элементов. Значение N вводится с клавиатуры.");
            methods.Print(methods.GetNumbersFibonachi(methods.GetOneIntKeyboard()));
            break;
        case (7):
            methods.Print("Проверка гипотезы Сиракуз.");
            methods.Print(methods.GetSeracuz());
            break;
        case (8):
            methods.Print("Извлечение цифр числа.");
            methods.Print("Введите целое число: ");
            methods.Print(methods.GetNumbers(methods.GetOneIntKeyboard()));
            break;
        case (9):
            Environment.Exit(0);
            break;
    }
    StartProgramm();
}
