// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// 0, 7, 8, -2, -2 -> 2   
// 1, -7, 567, 89, 223-> 3


int[] GetArray(string numbers)           
{

    string[] num = numbers.Split(",");

    int[] newarray = Array.ConvertAll(num, int.Parse);
    for (int i = 0; i < newarray.Length; i++)
    {
        Console.Write(newarray[i] + " ");
    }

    return newarray;
}


int GetSum(int[] array)
{
    int temp = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            temp++;
        }
    }
    return temp;
}


Console.Clear();
Console.WriteLine("Введите числа через запятую :");
string numbers = Console.ReadLine();

Console.WriteLine("Массив: ");
int[] el = GetArray(numbers);
int temp = GetSum(el);

Console.WriteLine();
Console.WriteLine(temp + " Чисел больше нуля ввёл пользователь");

