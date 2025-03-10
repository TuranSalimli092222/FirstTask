#region task1
//task1
//1-den 100-e qeder ededler arasinda cut ededleri tapan alqoritm yazirsiz.( for loop)
/*Console.WriteLine("Even numbers:");
for (int i = 0; i < 100; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}*/
#endregion
#region task2
//task2
//1-den 100-e qeder ededler arasinda cut ededleri tapan alqoritm yazirsiz.( while loop)
/*int num = 0;
Console.WriteLine("Even numbers:");
while (num < 100)
{
if (num % 2 == 0)
    {
        Console.WriteLine(num);
    }
num++;
}*/
#endregion
#region task3
//task3
//Array daxilinde yalniz sade ededleri capa veren alqoritm yazirsiz (for loop)

/*int[] arr = { 2, 4, 7, 9, 11, 13, 17, 18, 19, 25 };
Console.WriteLine("Simple elements within an array:");
for (int i = 0; i < arr.Length; i++)
{
    int n = arr[i];
    bool isPrime = true;
    if (n <= 1)
    {
        isPrime = false;
    }
    for (int j = 2; j <= Math.Sqrt(n); j++)
    {
        if (n % j == 0)
        {
            isPrime = false;
            break;
        }

    }
        if (isPrime)
        {
            Console.WriteLine(arr[i]);
        }
}*/
#endregion
#region task4
//task4
//Array daxilinde yalniz sade ededleri capa veren alqoritm yazirsiz (while loop)
/*int[] arr = { 2, 4, 7, 9, 11, 13, 17, 18, 19, 25 };
int i = 0;
Console.WriteLine("Simple elements within an array:");
while (i < arr.Length)
{
    int n = arr[i];
    bool isPrime = true;
    if (n <= 1)
    {
        isPrime = false;
    }
    for (int j = 2; j <= Math.Sqrt(n); j++)
    {
        if (n % j == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine(arr[i]);
    }

    i++;
}*/
#endregion