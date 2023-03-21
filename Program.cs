//задача. 
//Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которвых меньше или равна 3 символам 

Console.Clear(); 

Console.Write("Введите сколько элементов будет в массиве: ");

int elementsCount = int.Parse(Console.ReadLine()!);

string[] set1 = new string[elementsCount];

for (int i = 0; i < set1.Length; i++)
{
    Console.WriteLine("Введите данные для массива: ");
    set1[i] = Convert.ToString(Console.ReadLine()!);
}

string[] set2 = new string[set1.Length];

void SecondArrayWithIF(string[] set1, string[] set2)
{
    int count = 0;
    for (int i = 0; i < set1.Length; i++)
    {
    if(set1[i].Length <= 3)
        {
        set2[count] = set1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(set1, set2);
PrintArray(set2);