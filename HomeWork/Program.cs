//Домашняя задача 2.

//Задача 10

/*
int FindeNum(int num)
{
    if(num > 99 && num < 1000)
    {
        int ed = num % 100;
        int res = ed / 10;
        return res; 
    }
    return -1;
}

Console.Write("Введите трех значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num2 = FindeNum(number);
Console.WriteLine($"Из числа {number} второе число {num2}");
*/

// Задача 13

/*
int FindeNum(int num)
{
    if(num > 99 && num < 1000)
    {
        int res = num % 10;
        return res;
    }
    if (num > 999 && num < 10000)
    {
        int ed = num / 10;
        int res = ed % 10;
        return res;
    }
    if (num > 9999 && num < 100000)
    {
        int ed = num / 100;
        int res = ed % 10;
        return res;
    }
    if (num > 99999 && num < 1000000)
    {
        int ed = num / 1000;
        int res = ed % 10;
        return res;
    }
     if (num > 999999 && num < 10000000)
    {
        int ed = num / 10000;
        int res = ed % 10;
        return res;
    }
    if (num > 9999999 && num < 100000000)
    {
        int ed = num / 100000;
        int res = ed % 10;
        return res;
    }
    return -1;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ans = FindeNum(number);
Console.WriteLine($"Тертья цифра числа {number} равна {ans}");
*/

//Задача 15

/*
string FindeDay(int num)
{
    if (num >= 1 && num <=5)
    {
        return("Не выходной.");

    }
    if (num == 6 || num == 7)
    {
        return("Выходной.");

    }
    else
        return("Не правильное число.");

}

Console.Write("Введите число обозначающее день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
string ans = FindeDay(number);

Console.WriteLine($"{number} -> {ans}");
*/