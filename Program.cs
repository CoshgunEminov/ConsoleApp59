namespace ConsoleApp59
{
     public class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 80, 90, 100 };

            double average = CalcAvg(grades); 

           
            if (average > 60)
            {
                Console.WriteLine("Mezun oldunuz");
            }
            else
            {
                Console.WriteLine("Mezun olamadınız");
            }
        }

        static double CalcAvg(int[] grades)
        {
            int sum = 0;
            foreach (int grade in grades)
            {
                sum += grade;
            }
            return (double)sum / grades.Length;
        }
    }
}
   