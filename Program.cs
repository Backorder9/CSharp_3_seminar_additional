/* 1) Создать программу, которая из массива удаляется элемент с позиции,
которую введет пользователь.
2) Создание массива из двух массивов. В итоговом массиве должны быть
элементы первого и второго массива.
[1,2,3] [4,5,6] -> [1,2,3,4,5,6] */

public class SamplesArray
{
    public static void Main(string[] args)
    {
    Console.Write("Введите количество элементов создаваемого массива целых чисел: ");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine();

    int[] num = new int[N];
        for (int i = 0; i < N; i++)
        {
        num[i] = new Random().Next(0, 100);
        }
    
    Console.WriteLine($"Создан следующий массив, состоящий из {N} случайных целых чисел: " + String.Join(", ", num) + ".");
    Console.WriteLine();
    
    Console.Write("Введите значение элемента массива, который хотите удалить: ");
    int numToRemove = int.Parse(Console.ReadLine());
    Console.WriteLine();
    num = num.Where(val => val != numToRemove).ToArray();
    Console.WriteLine($"После удаления выбранного элемента ({numToRemove}) получился массив, состоящий из {num.Length} элементов: " + String.Join(", ", num) + ".");
    Console.WriteLine();

    Console.Write("Введите количество элементов создаваемого второго массива целых чисел: ");
    int M = int.Parse(Console.ReadLine());
    Console.WriteLine();
    int[] mundial = new int[M];
    for (int i = 0; i < M; i++)
    {
    mundial[i] = new Random().Next(100, 999);
    }
    Console.WriteLine($"Создан следующий второй массив, состоящий из {M} случайных целых чисел: " + String.Join(", ", mundial) + ".");
    Console.WriteLine();

    int[] result = num.Concat(mundial).ToArray();
    Console.WriteLine($"Создан объединённый массив, состоящий из {result.Length} случайных целых чисел: " + String.Join(", ", result) + ".");
    Console.WriteLine();
    }
}
