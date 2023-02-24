/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Write("Введите число А: ");
 int numberA = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите число B: ");
 int numberB = Convert.ToInt32(Console.ReadLine());

 int Begree(int numberA, int numberB);
 {
    int result = (numberA*numberA) * numberB;
    return result;
 }

 Console.WriteLine(Begree(numberA, numberB));