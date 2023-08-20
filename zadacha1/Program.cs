/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введи число: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введи степень: ");
int numberB = int.Parse(Console.ReadLine());

Check(numberB);

void Check(int num) {
    if (num < 0) {
        Console.WriteLine("Некорректный ввод степени!");
    } else if (num == 0) {
        Console.WriteLine("1");
    } else {
        int result = NumberPow(numberA, numberB);
        Console.WriteLine($"{numberA}, {numberB} -> {result}");
    }
}

int NumberPow(int x, int y) {
    int pow = x;
    for (int i = 1; i < y; i++) {
        pow = pow * x; 
    }
    return pow;
}