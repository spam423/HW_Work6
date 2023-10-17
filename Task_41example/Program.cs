/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

//Считать число с консоли


int Prompt(string message)
{
    System.Console.WriteLine(message); //вывести сообщение 
    string value = Console.ReadLine();  //Считывает с консоли строку
    int result = Convert.ToInt32(value);    //Преобразует строку в целое 
    //число
    return result;  // возвращает результат
}

//Ввести массив
int[] InputArray(int length)
{
    int[] array = new int [length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Enter {i+1} -element");
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }   
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = Prompt ("enter the number of elements >");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"amount of numbers > 0 = {CountPositiveNumbers(array)}");
