// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)

/*3, 5 -> 243 (3⁵)
0, 0 - >1
2, 4 -> 16*/

/*int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for(int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

Console.Write("Enter the number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
 Console.Write("Enter the number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("The answer is: " + exponentiation);*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*452 -> 11

82 -> 10

9012 -> 12*/

/*Console.WriteLine("Enter the number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int SumOfDigit(int numberA)
{
  int count = Convert.ToString(numberA).Length;
  int j = 0;
  int result = 0;

  for (int i = 0; i < count; i++)
  {
    j = numberA - numberA % 10;
    result = result + (numberA - j);
    numberA = numberA / 10;
  }  
  return result;
} 

int sumOfDigit = SumOfDigit(numberA);
Console.WriteLine("The sum of the digits in the number is: " + sumOfDigit);*/

// Задача 29: Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.

/*1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

Console.Write("Enter the number of array elements:\t");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsCount];

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Enter an array element below the index {i}:\t");
    myArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Вывод массива:");
for (int i = 0; i < myArray.Length; i++)
{

    Console.Write(myArray[i] + ", ");
}
//Console.ReadLine();