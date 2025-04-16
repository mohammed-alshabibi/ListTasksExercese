namespace ListTasksExercese
{
    internal class Program
    {
        static List<int> numbers = new List<int>();
        static List<int> duplication = new List<int>();
        static void Main(string[] args)
        {


            Console.WriteLine("Enter Number of List:");
            int n = int.Parse(Console.ReadLine());// number of elements in the list
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i + 1} number :");
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            List<int> TopFreqNum = GetTopFreqNum(n);
            // Iterate into the top frequency list and print each element with its frequency
            Console.WriteLine("The top frequency numbers are:");
            foreach (int num in TopFreqNum)
            {
                int index = numbers.IndexOf(num); // Get the index of the number in the original list
                Console.WriteLine($"Number: {num}, Frequency: {duplication[index]}");
            }


            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Enter the number to shift the list:");
            int shift =int.Parse(Console.ReadLine());
            List<int>shiftList=ShiftListElement(shift);
            // iterate into shfit list and print each element
            foreach (int num in shiftList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("--------------------------------------------");
            List<string>Words =new List<string>();
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Enter Words:");
                string str = Console.ReadLine();
                Words.Add(str);  
            }
            foreach(string str in Palindrome(Words))
            {
                Console.WriteLine("The Non-Palindrime Word/s is: "+str);
            }
        }
        public static List<int> GetTopFreqNum(int n)
        {
            List<int> freqNumList = new List<int>();
            List<int> uniqueNumbers = new List<int>();
            List<int> frequencies = new List<int>();

            

            // Calculate the frequency of each number
            for (int i = 0; i < numbers.Count; i++)
            {
                if (!uniqueNumbers.Contains(numbers[i]))
                {
                    uniqueNumbers.Add(numbers[i]);
                    int frequency = 0;//reset the freq

                    // loop through the list to count the frequency of the current number
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            frequency++;
                        }
                    }

                    frequencies.Add(frequency);
                }
            }

            // 
            foreach (int number in numbers)
            {
                int index = uniqueNumbers.IndexOf(number);
                duplication.Add(frequencies[index]);
            }

            // Display the frequency of each unique number
            for (int i = 0; i < uniqueNumbers.Count; i++)
            {
                Console.WriteLine($"The frequency of {uniqueNumbers[i]} is {frequencies[i]}");
            }

            // Sort uniqueNumbers and frequencies based on frequency in descending order
            for (int i = 0; i < frequencies.Count - 1; i++)
            {
                for (int j = i + 1; j < frequencies.Count; j++)
                {
                    if (frequencies[i] < frequencies[j])
                    {
                        // Swap frequencies
                        int tempFreq = frequencies[i];
                        frequencies[i] = frequencies[j];
                        frequencies[j] = tempFreq;

                        // Swap corresponding unique numbers
                        int tempNum = uniqueNumbers[i];
                        uniqueNumbers[i] = uniqueNumbers[j];
                        uniqueNumbers[j] = tempNum;
                    }
                }
            }

            // Ask the user for the top N frequent numbers
            Console.WriteLine($"Enter the number of top frequent elements to display (N):");
            int topN = int.Parse(Console.ReadLine());

            // Get the top N frequent numbers
            for (int i = 0; i < topN && i < uniqueNumbers.Count; i++)
            {
                freqNumList.Add(uniqueNumbers[i]);
            }

            return freqNumList;
        }


        // function that rotates the elements of a List<int> to the right by k steps
        public static List<int> ShiftListElement(int shift)
        {
            List<int> shiftedList = new List<int>(new int[numbers.Count]);
            // Check if the shift value is less than the size of the list
            if (shift < numbers.Count)
            {
                shift = shift % numbers.Count; // Ensure shift is within the bounds of the list size
                for (int i = 0; i < numbers.Count; i++)
                {
                    //Ensure that rorate to the right without exceeding the list size,avoit out of range
                    shiftedList[(i + shift) % numbers.Count] = numbers[i];
                }

            }
            else
            {
                Console.WriteLine("The shift value is greater than the list size.");
            }

                return shiftedList;
        }
        public static bool CheckPlaindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false; // Not a palindrome
                }
                left++;
                right--;
            }
            return true; // Is a palindrome
        }
        public static List<string> Palindrome(List<string> str) 
        {
            List<string> PalindromList = new List<string>();
            foreach (string str2 in str)
            {
                if (!CheckPlaindrome((string)str2))
                {
                    PalindromList.Add(str2);
                }
            }
            return PalindromList;


        }

    }
}
