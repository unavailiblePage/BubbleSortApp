using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        int[] unsortedNumbers = { 34, 22, 89, 64, 78, 3, 99, 1, 31, 125, 5, 15, 2 }; //, 64, 78, 3, 99, 1, 31, 125, 5, 15, 2 
        Console.WriteLine("Unsorted numbers:");
        for (int i = 0; i < unsortedNumbers.Length; i++)
        {
            Console.Write(unsortedNumbers[i] + "; ");
        }
        Console.WriteLine();
        int[] sortedNumbers = BubbleSort(unsortedNumbers);
        Console.WriteLine("Sorted numbers:");
        for (int i = 0; i < unsortedNumbers.Length; i++)
        {
            Console.Write(unsortedNumbers[i] + "; ");
        }
        Console.WriteLine();
    }


    // study:
    // https://www.productplan.com/glossary/bubble-sort/
    public static int[] BubbleSort(int[] numbers)
    {
        int counter = 0;
        int i = 0;

        while (counter != numbers.Length)
        {
            if (i == numbers.Length - 1)
            {
                i = 0;
            } 
            
            int index1 = numbers[i];
            int index2 = numbers[i + 1];

            if (index1 > index2)
            {
                int index3 = index2;
                index2 = index1;
                index1 = index3;
                numbers[i] = index3;
                numbers[i + 1] = index2;
                counter = 0;
            }
            counter++;
            i++;
        }
        return numbers;
    }
}
