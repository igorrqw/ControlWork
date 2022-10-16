//  Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.WriteLine("Введите размер массива");

int size = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[size];

for (int i = 0; i < size; i++)
{
    Console.WriteLine("Введите слово");
    string? value = Console.ReadLine();

    if (value == null || value == string.Empty)
    {
        value = "Вы_не_ввели_слово";
    }
    arr[i] = value;
}

int sizeForFilteredArray = 0 ;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        sizeForFilteredArray++;
    }
}

string[] filteredArray = new string[sizeForFilteredArray];
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        filteredArray[count] = arr[i];
        count++;
    }

}

Console.Write("Результат: [");

for (int i = 0; i < filteredArray.Length; i++)
{
    Console.Write($"{filteredArray[i]}, ");
}

Console.Write("]");