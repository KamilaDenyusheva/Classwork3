// Напишите программу, которая рандомно выбирает число от(10 до 99), и показывает максимальную цифру их этого числа

/*
int Number (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int max;
    if (firstDigit> secondDigit)
        max = firstDigit;
    else
        max = secondDigit;
    return max;
}

int randNum = new Random().Next(10,100);
int n = Number(randNum);
Console.WriteLine($"Random digit is {randNum}, and max digit is {n}");
*/

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*
bool IsEven (int num1, int num2)
{
    if ((num1 == num2*num2) || (num2 == num1*num1))
        return true;
    else
        return false;
}

Console.WriteLine("Введите первое число ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int n2 = Convert.ToInt32(Console.ReadLine());

bool result = IsEven(n1, n2);
Console.WriteLine(result);
*/

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/*

bool IsEven (int n1, int n2)
{
    if (n1 % n2 == 0)
        return true;
    else
        return false;
}

Console.WriteLine("Введите первое число ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int n2 = Convert.ToInt32(Console.ReadLine());

bool result = IsEven(n1, n2);
Console.WriteLine(result);

*/