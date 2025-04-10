

static void Main(string[] args)
{
    int[] ints = { 1, 2, 3, 4, 5 };
    int counter = 0;
    for (int i = 0; i < ints.Length; i++)
    {
        counter += ints[i];
    }
    Console.WriteLine(counter);
}
static void Main1(string[] args)
{
    int[,] ints = new int[3, 3];

    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Random rnd = new Random();
            ints[i, j] = rnd.Next(1, 3);
        }
    }
    int counter = 0;
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Console.Write(ints[i, j] + " ");
            counter += ints[i, j];

        }
        Console.WriteLine();
    }
    Console.WriteLine(counter);

}

static void Main3(string[] args)
{
    int[,] ints = new int[3, 3];

    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Random rnd = new Random();
            ints[i, j] = rnd.Next(1, 10);
        }
    }

    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Console.Write(ints[i, j] + " ");
        }
        Console.WriteLine();
    }

}

static void Main5(string[] args)
{
    int[,] ints = new int[2, 2];

    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {

            Random rnd = new Random();
            ints[i, j] = rnd.Next(1, 20);

        }
    }
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Console.Write(ints[i, j] + " ");

        }
        Console.WriteLine();
    }

    for (int i = 0; i < ints.GetLength(0); i++)
    {
        int counter = 0;
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            counter += ints[i, i];
        }
        Console.Write(counter + " ");
    }
}
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");