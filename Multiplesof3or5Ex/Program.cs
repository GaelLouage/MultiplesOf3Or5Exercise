internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Solution(10));
    }

    public static int Solution(int value)
    {
        var result = 0;
        for (int i = 0; i < value; i++) 
        {
            if(i%3 == 0 || i %5  == 0)
            {
                result += i;
            }
        }
        return result;
    }
}