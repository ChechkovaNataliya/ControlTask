// Вывести все четные элементы массива.

int[] array = { 1, 3, 4, 5, 7, 1, 3}; 
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
PrintArray(array);
EvenNumber(array);