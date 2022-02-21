namespace Ex04.Menus.Test
{
    using System;
    using System.Threading;

    public class Methods
    {
        public static void CountCapitals()
        {
            Console.Clear();
            Console.WriteLine("Please enter your sentence:");
            string userStringInput = checkUserStringInput();
            int countCapitals = 0;

            foreach (char singleLetter in userStringInput)
            {
                if (char.IsUpper(singleLetter))
                {
                    countCapitals++;
                }
            }

            string message = string.Format("There are {0} Capitals in the your sentence.", countCapitals);

            Console.WriteLine(message);
            goBack();
        }

        private static string checkUserStringInput()
        {
            string userStringInput = Console.ReadLine();

            while (userStringInput.Length == 0)
            {
                Console.WriteLine("String Is Empty Enter Another");
                userStringInput = Console.ReadLine();
            }

            return userStringInput;
        }

        public static void ShowVersion()
        {
            Console.Clear();
            Console.WriteLine("Version: 22.1.4.8930");
            goBack();
        }

        private static void goBack()
        {
            Console.WriteLine("Going Back Now..........");
            Thread.Sleep(2000);
        }

        public static void ShowDate()
        {
            Console.Clear();
            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");

            Console.WriteLine("The current date is {0}", date);
            goBack();
        }

        public static void ShowTime()
        {
            Console.Clear();
            string time = DateTime.Now.ToString("HH:mm:ss tt");

            Console.WriteLine("The current time is {0}", time);
            goBack();
        }
    }
}