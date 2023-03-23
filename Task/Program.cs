// Написать программу, которая из имеющегося массива строк формирует массив 
// из строк, длина которых меньше либо равна 3 символа. Первоначальный массив 
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

Console.WriteLine("Введите колличество элементов в массиве");
int element = Convert.ToInt32(Console.ReadLine());
string[] myArray = new string[element];

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"Введите строку масcива с индексом {i}");
    myArray[i] = Convert.ToString(Console.ReadLine());
    
}
string[] array = new string[myArray.Length];
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i].Length <= 3)
    {
        array[i] = myArray[i];
    }
}
Console.WriteLine($"[{string.Join(" ", myArray)}] -> [{string.Join(" ", array)}]");