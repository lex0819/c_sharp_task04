/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

int[] numbers={0,0,0};

for (int i = 0; i < numbers.Length; i++)
{
  Console.WriteLine($"Enter {i+1}-th number :");
  string numberStr = Console.ReadLine() ?? "";
  if(!(int.TryParse(numberStr, out int number))){
    Console.WriteLine($"invalid input");
    return;
  }
  else
  {
    numbers[i] = number;
  }
}

int max = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
  if(numbers[i] > max){
    max = numbers[i];
  }
}

//Output result
for (int i = 0; i < numbers.Length; i++)
{
  Console.Write($"{numbers[i]}, ");
}
Console.Write($" -> {max}");