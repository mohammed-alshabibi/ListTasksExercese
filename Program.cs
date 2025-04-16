namespace ListTasksExercese
{
    internal class Program
    {
        static List<int> numbers = new List<int>();
        static void Main(string[] args)
        {


            Console.WriteLine("Enter Number of List:");
            int n =int.Parse(Console.ReadLine());// number of elements in the list
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i + 1} number :");
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            int TopFreqNum=GetTopFreqNum(n);
            Console.WriteLine("The Top Frequency Number is: " + TopFreqNum);



        }
        public static int GetTopFreqNum(int input)
        {
            
            int maxFreq = 0;
            int freqElement = numbers[0];
            // outer loop that iterate in list count
            for (int i = 0; i < numbers.Count; i++)
            {
                int frequency = 0;// reset in every iteration to count frequency of each number 
                for (int j = 0; j < numbers.Count; j++)
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
            return freqElement;
        }

    }
}
