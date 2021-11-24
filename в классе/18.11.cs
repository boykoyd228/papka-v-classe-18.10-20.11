class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        int max = 0;
        int min = 1000000;
        int min_i = -1;
        int max_i = -1;
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
            if (array[i] < min)
            {
                min = array[i];
                min_i = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                max_i = i; ;
            }
        }
        int s = array[max_i];
        array[max_i] = array[min_i];
        array[min_i] = s;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}