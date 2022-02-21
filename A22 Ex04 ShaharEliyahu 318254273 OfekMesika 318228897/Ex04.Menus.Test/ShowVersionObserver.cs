namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class ShowVersionObserver : ICLickedObserver
    {
        public void Clicked()
        {
            Methods.ShowVersion();
        }
    }
}
