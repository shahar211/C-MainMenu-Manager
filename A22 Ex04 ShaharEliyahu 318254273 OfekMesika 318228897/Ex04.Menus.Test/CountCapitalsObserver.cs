namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class CountCapitalsObserver : ICLickedObserver
    {
        public void Clicked()
        {
            Methods.CountCapitals();
        }
    }
}
