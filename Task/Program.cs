// Вывести все четные элементы массива.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 20);
    }
}

void PrintArray(int[] array) 
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); 
    }
    Console.WriteLine(); 
}

void EvenNumber(int[] array) 
{
    for (int i = 0; i < array.Length; i++) 
    {
        if((array[i]) % 2 == 0)
         {
            Console.Write($"{array[i]} ");
         }
    }
    Console.WriteLine(); 
 }
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.Write($"Чётные числа: ");
EvenNumber(array);