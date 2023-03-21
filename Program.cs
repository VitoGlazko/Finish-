//задача. 
//Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которвых меньше или равна 3 символам 

Console.Clear(); //Чистим консоль

Console.Write("Введите сколько элементов будет в массиве: ");//Запрашиваем у пользователя сколько элементов будет в массиве

int elementsCount = int.Parse(Console.ReadLine()!);//Вносим данные в переменную

string[] set1 = new string[elementsCount];//Создаём массив размером elementsCount

for (int i = 0; i < set1.Length; i++)//Создаём цикл что бы заменить значение каждого элемента
{
    Console.WriteLine("Введите данные для массива: "); //просим пользователя ввести данные для массива
    set1[i] = Convert.ToString(Console.ReadLine()!);//меняем значение элементов массива на те что ввёл пользователь
}

string[] set2 = new string[set1.Length];//Создаём дополнительный пустой массив равный длине первого

void SecondArrayWithIF(string[] set1, string[] set2)//Создаём функцию для отсеевания ненужных элементов массива 
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

void PrintArray(string[] array)//Создаём функцию для печати нового массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(set1, set2);
PrintArray(set2);