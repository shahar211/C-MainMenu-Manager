namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class ShowDateObserver : ICLickedObserver
    {
        public void Clicked()
        {
            Methods.ShowDate();
        }
    }
}
