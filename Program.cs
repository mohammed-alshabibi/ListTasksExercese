namespace ListTasksExercese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> numbers = new List<int>();
            List<int> duplicates = new List<int>();
            Console.WriteLine("Enter 6 numbers :");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter "+ i+1 +" number :");
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            int frequency = 0;
            int maxFreq = 0;
            int FirstElement = numbers[0];
            for (int i = 0; i<numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        frequency++;
                    }
                }
            }
            if (frequency == 0)
            {
                Console.WriteLine("All numbers are unique.");
            }
            else
            {

                Console.WriteLine("There are " + frequency + " duplicate numbers."+ duplicates);
            }
        }

    }
}
