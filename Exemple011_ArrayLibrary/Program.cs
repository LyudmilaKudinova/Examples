void FillArray(int[] collection) 
// void не возвращает заначение поэтому нельзя писать в конце return
                               
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index+1;
       index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; 
    // -1 поставили чтобы им обозначать не найденный в массиве элемент
    while (index < count)
    {
        if(collection[index] == find)
        {
             position = index;
             break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; // создай новый массив в котором будет 10 элементов

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();
int pos = Indexof(array, 556);// специально поставили 556 для проверки и вывода -1
Console.WriteLine(pos);