namespace GradingSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int score))
            {
                Grading.GradeCalculator(score);
            }
            else
            {
                Console.WriteLine("Error: Score should be in digit only (" + input + ")");
            }
        }
    }
}