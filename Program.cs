class Assignment6
{
    public static void Main(string[] args)
    {
        int num;

        Console.Write("Enter Your Number: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nUsing For Loop");
        // Using for loop
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} * {i} = {num * i}");
        }

        Console.WriteLine("\nUsing While Loop");
        // Using while loop
        int j = 1;
        while (j <= 10)
        {
            Console.WriteLine($"{num} * {j} = {num * j}");
            j++;
        }
    }
}
