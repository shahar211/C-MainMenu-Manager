namespace Ex04.Menus.Test
{
    using System;
    using Ex04.Menus.Delegates;
    using Ex04.Menus.Interfaces;

    public class Program
    {
        public static void Main()
        {
            runInterfaces();
            runDelegate();
            Console.ReadLine();
        }

        private static void runInterfaces()
        {
            Interfaces.MainMenu main = new Interfaces.MainMenu("Interfaces Main Menu");
            Interfaces.SubMenu versionAndCapitals = main.AddSubMenu(1, "Version and Capitals", main.SubMenu);
            Interfaces.MenuItem countCapitals = versionAndCapitals.AddMenuItem(1, "Count Capitals");
            Interfaces.MenuItem showVersion = versionAndCapitals.AddMenuItem(2, "Show Version");
            Interfaces.SubMenu showDataAndTime = main.AddSubMenu(2, "Show Data And Time", main.SubMenu);
            Interfaces.MenuItem showData = showDataAndTime.AddMenuItem(1, "Show Data");
            Interfaces.MenuItem showTime = showDataAndTime.AddMenuItem(2, "Show Time");

            countCapitals.AttachObserver(new CountCapitalsObserver());
            showVersion.AttachObserver(new ShowVersionObserver());
            showData.AttachObserver(new ShowDateObserver());
            showTime.AttachObserver(new ShowTimeObserver());
            main.Show();
            Console.Clear();
        }

        private static void runDelegate()
        {
            Delegates.MainMenu main = new Delegates.MainMenu("Delegates Main Menu");
            Delegates.SubMenu versionAndCapitals = main.AddSubMenu(1, "Version and Capitals", main.SubMenu);
            Delegates.MenuItem countCapitals = versionAndCapitals.AddMenuItem(1, "Count Capitals");
            Delegates.MenuItem showVersion = versionAndCapitals.AddMenuItem(2, "Show Version");
            Delegates.SubMenu showDataAndTime = main.AddSubMenu(2, "Show Data And Time", main.SubMenu);
            Delegates.MenuItem showData = showDataAndTime.AddMenuItem(1, "Show Data");
            Delegates.MenuItem showTime = showDataAndTime.AddMenuItem(2, "Show Time");

            countCapitals.Clicked += MethodsDelegate.CountCapitalsDelegate;
            showVersion.Clicked += MethodsDelegate.ShowVersionDelegate;
            showData.Clicked += MethodsDelegate.ShowDateDelegate;
            showTime.Clicked += MethodsDelegate.ShowTimeDelegate;
            main.Show();
            Console.Clear();
            Console.WriteLine("Good Bye");
        }
    }
}
