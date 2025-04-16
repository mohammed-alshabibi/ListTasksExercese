namespace ListTasksExercese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> numbers = new List<int>();
            
            Console.WriteLine("Enter 6 numbers :");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Enter {i+1}  number :");
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            
            int maxFreq = 0;
            int freqElement = numbers[0];
            // outer loop that iterate in list count
            for (int i = 0; i<numbers.Count; i++)
            {
                int frequency = 0;// reset in every iteration to count frequency of each number 
                for (int j = 0 ; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        frequency++;// increament frequency
                    }
                }
                // check the frequency with max freq
                if (frequency > maxFreq)
                {
                    maxFreq = frequency;
                    freqElement = numbers[i];
                }
            }
            Console.WriteLine("The Top Frequncy number is " + freqElement+" repeated "+maxFreq);
            
        }

    }
}
