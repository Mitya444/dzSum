using System.ComponentModel.DataAnnotations;

var random = new Random();
int[,] arrange = new int[5, 5];
int sum = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        arrange[i, j] = random.Next(-10, 10);
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(arrange[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < 5; i++)
{
    sum = sum + arrange[i, i];
}
Console.WriteLine($"Sum of number on diagonal: {sum}");