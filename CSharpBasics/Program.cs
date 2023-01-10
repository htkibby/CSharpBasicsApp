namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name: ");
            //string input = "";

            //while(input == "" || input.StartsWith("QQ"))
            //{
            //    Console.WriteLine("Please input a real name.");
            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"Hello, {input}");

            Console.Write("Enter your Name");
            string name = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(name))
            {
                Console.Write("Please enter a valid name");
                name = Console.ReadLine();
            }

            Console.Clear();

            Console.Write("What is your favorite day of the week?");
            string dayOfWeek = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(dayOfWeek))
            {
                Console.Write("Please enter a valid day of the week.");
                dayOfWeek = Console.ReadLine();
            }

            Console.Clear();

            Console.Write("What is your least favorite school subject?");
            string schoolSubject = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(schoolSubject))
            {
                Console.Write("Please enter a valid subject.");
                schoolSubject = Console.ReadLine();
            }

            Console.Clear();

            string displayText = 
@$"Name: {name} 
Favorite Day of the Week: {dayOfWeek} 
Least Favorite School Subject: {schoolSubject} ";

            Console.Write(displayText);

            Console.ReadLine();
        }
    }
}