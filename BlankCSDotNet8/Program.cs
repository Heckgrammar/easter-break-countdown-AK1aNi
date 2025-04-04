namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What year will your spring break happen: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What month (in numbers of the year) will spring break start: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What day (in numbers of the month) will spring break start: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What hour (24 hours) will spring break start");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What minute will spring break start: ");
            int minute = Convert.ToInt32(Console.ReadLine());
            DateTime current = DateTime.Now;
            DateTime target = new DateTime(year, month, day, hour, minute, 0);
            TimeSpan difference = target - current;

            while (difference.Seconds > 0)
            {
                current = DateTime.Now;
                difference = target - current;
                if (difference.Days > 0)
                {
                    Console.WriteLine("There are " + difference.Days + " days, " + difference.Hours + " hours, " + difference.Minutes + " minutes, " + difference.Seconds + " seconds left until spring break.");
                }
                else
                {
                    Console.WriteLine("There are " + difference.Hours + " hours, " + difference.Minutes + " minutes, " + difference.Seconds + " seconds left until spring break.");
                }
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("Spring break has strarted.");




        }
    }
}
