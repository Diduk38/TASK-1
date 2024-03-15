
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Modification 1");

        Console.WriteLine("Modification 2.");

        Console.WriteLine("Modification 3.");

        int[] arr = {1,2,3,4,5,6,7,8,9,10};

        double averageOfArray=Average(arr);
        
        Console.WriteLine(averageOfArray);
    }

    static double Average(int[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];

        }

        double averageVariable = sum / array.Length;
        return averageVariable;
    }

}

