Console.Write("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine());
int counter = Convert.ToString(number).Length; 
int remain = 0;
int result = 0;
for (int i = 0; i < counter; i++)
    {
      remain = number - number % 10; 
      result = result + (number - remain); 
      number = number / 10; 
    }
Console.WriteLine("Сумма цифр в числе: " + result);