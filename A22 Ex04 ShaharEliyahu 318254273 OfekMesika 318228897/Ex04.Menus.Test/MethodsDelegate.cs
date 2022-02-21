namespace Ex04.Menus.Test
{
    public class MethodsDelegate
    {
        public static void ShowTimeDelegate(Delegates.MenuItem i_DelegatesMenuItem)
        {
            Methods.ShowTime();
        } 
        
        public static void ShowDateDelegate(Delegates.MenuItem i_DelegatesMenuItem)
        {
            Methods.ShowDate();
        }

        public static void CountCapitalsDelegate(Delegates.MenuItem i_DelegatesMenuItem)
        { 
            Methods.CountCapitals();
        }
        
        public static void ShowVersionDelegate(Delegates.MenuItem i_DelegatesMenuItem)
        {
            Methods.ShowVersion();
        }
    }
}
