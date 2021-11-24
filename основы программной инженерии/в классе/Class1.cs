class Program
{
    static void Main(string[] args)
    {
        string aue = Console.ReadLine();
        string snus = aue.Replace(" ", "");
        Console.WriteLine($"{snus}");
        bool auf = true;
        for (int i = 0; i < snus.Length; i++)
        {
            if (snus[i] == snus[snus.Length - 1 - i])
            {
                auf = true;
            }
            else
            {
                auf = false;
            }
            if (!auf)
            {
                Console.WriteLine("This is not a polyndrom");
                break;
            }
        }
        if (auf)
        {
            Console.WriteLine("This is polyndrom");
        }
    }
}