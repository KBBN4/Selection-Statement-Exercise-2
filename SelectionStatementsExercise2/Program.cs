namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what is your favorite school subject?");
            string answer = Console.ReadLine();

            switch (answer.ToLower())

            {

                case "english":
                    Console.WriteLine("Good luck");
                    break;

                case "math":
                    Console.WriteLine("Calculator will be your best friend");
                    break;

                case "science":
                    Console.WriteLine("This is where the magic happens");
                    break;

                case "pe":
                    Console.WriteLine("This is one is sooo good ! ");
                    break;

                case "lunch":
                    Console.WriteLine("oh , this is one is my favorite too! ");
                    break;

                default:
                    Console.WriteLine(" Your school was no fun!");
                    break;

               
            }


        }
    }
}