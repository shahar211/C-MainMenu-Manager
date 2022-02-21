namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class ShowTimeObserver : ICLickedObserver
    {
        public void Clicked()
        {
            Methods.ShowTime();
        }
    }
}
