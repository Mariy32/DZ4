// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Number(int A, int B)
 
// {
// int result = 1;

//   for (int i=1; i <= B; i++)
//   {
//       result = result * A;
//   }
//    return result;
//   }
    
// Console.WriteLine("Введите число A");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int numberB = Convert.ToInt32(Console.ReadLine());

// int result = Number(numberA, numberB);
// Console.WriteLine(result);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



//   int Sum(int A)
//   {
//     int counter = Convert.ToString(A).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < counter; i++)
//     {
//       advance = A - A % 10;
//       result = result + (A - advance);
//       A = A / 10;
//     }
//    return result;
//   }

// Console.Write("Введите число ");
// int A = Convert.ToInt32(Console.ReadLine());

// int sum = Sum(A);
// Console.WriteLine(sum);





// int Number (int num)
// {
// int sum = 0; 
// while ( num >= 0)
// {
//     int os = num % 10;
//     sum = sum + os;
// }
// return sum;
// }
   
// Console.WriteLine("Введите число");
// int A = Convert.ToInt32(Console.ReadLine());
// int result = Number(A);
// Console.WriteLine(result);





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray (int size,int minValue, int maxValue)
{
int[] myArray = new int[size];
{
for(int i=0;i<size;i++)
{
myArray[i] = new Random().Next(minValue,maxValue+1);
}
return myArray;
}

void ShowArray(int[] array)
{
Console.WriteLine("Полученный массив ->:");
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i]+" ");
}
Console.WriteLine();
}
}
Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:");
int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(lenght,min,max);
// ShowArray(newArray);

ShowArray(CreateRandomArray(lenght,min,max));
