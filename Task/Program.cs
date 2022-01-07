// Вывести все четные элементы массива.

int[] array = {12,2,32,43,15,61,17,18}; 
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