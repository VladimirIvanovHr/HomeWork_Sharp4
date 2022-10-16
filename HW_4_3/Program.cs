//Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.


int size = 8;
int[] numbers = new int[size];
FillArray (numbers);
Console.WriteLine("Изначальный массив");
PrintArray (numbers);
SortingArray (numbers);
Console.WriteLine("Сортировка");
PrintArray (numbers);

    void FillArray (int[] num)
    {   
        for (int i = 0; i < num.Length; i++)
        {
        Random random = new Random();
        num[i] = random.Next(-100, 100);
        }
    }

    void SortingArray (int[] num)
    {
            
    int indx; 
    for (int i = 0; i < num.Length; i++)
    {
    indx = i;
    for (int j = i; j < num.Length; j++)
        {
            if (Math.Abs(num[j]) < Math.Abs(num[indx]))  
            {
                indx = j;
            }
        }

        if (num[indx] == num[i]) 
            continue;
        
        int temp = num[i];
        num[i] = num[indx];
        num[indx] = temp;
    }

    }

    void PrintArray (int[] num)
    {

    for (int i = 0; i < size; i++)
    {
        Console.Write(num[i] + "\t"); 
    }
    Console.WriteLine();
    }