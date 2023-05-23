// Задача 25. Напишите цикл, который принимает на вход 2 числа (А и В) и возводит число А в натуральную степень В.

/*
Console.WriteLine("Input number A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number B: ");
int B = Convert.ToInt32(Console.ReadLine());

int stepen = 1;
int multiple = 1;

if(B > 0)
{
    while(stepen <= B)
    {
    multiple = multiple * A;
    stepen = stepen + 1;
    }
    Console.WriteLine($"Result is {multiple}");
}

else
{
    Console.WriteLine("Impossible value");
}
*/

// Задача 27. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

/*
int Summ(int num)
{
    int sum = 0;
   
    while(num > 0)
    {
        int forsumm = num % 10;
        num = num / 10;
        sum = sum + forsumm;
    }
return sum;
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int S = Summ(number);

Console.WriteLine($"Summ of numbers is {S}");
*/

// Задача 29. Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

/*
int [] CreateRandomArray (int size)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(); 
    return newArray;
}

void ShowArray (int [] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write (array1[i]+ " ");
    Console.WriteLine();
}

int sizeArray = 8;

int [] createdArray = CreateRandomArray(sizeArray);
ShowArray(createdArray);
*/