

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