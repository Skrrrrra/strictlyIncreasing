namespace strictlyIncreasing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrSize = Convert.ToInt32(Console.ReadLine());
            string line;
            bool[] answers = new bool[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                int lineSize = Convert.ToInt32(Console.ReadLine());
                if (lineSize != 1)
                {

                    int[] numbers = new int[lineSize];
                    line = Console.ReadLine();
                    string[] linee = line.Split(' ');
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        numbers[j] = Convert.ToInt32(linee[j]);
                    }
                    Array.Sort(numbers);
                    
                    for (int j = 0; j < numbers.Length - 1; j++)
                    {
                        if (numbers[j] >= numbers[j + 1])
                        {
                            answers[i] = false;
                            break;
                        }
                        else
                        {
                            answers[i] = true;
                            break;
                        }
                    }
                }
                else
                {
                    line = Console.ReadLine();
                    answers[i] = true;
                    break;
                }
            }

            for (int j = 0; j < answers.Length; j++)
            {
                if (answers[j] == false)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("Yes");
                }
            }
        }
    }
}