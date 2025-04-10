

   
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            int maxs = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > maxs) maxs = ints[i];

            }
            Console.WriteLine(maxs);
        }

  
