namespace Ex04.Menus.Interfaces
{
    using System.Collections.Generic;

    public class MenuItem
    {
        private readonly string r_Title;
        private readonly List<ICLickedObserver> r_CLickedObserver = new List<ICLickedObserver>();

        public MenuItem(string i_Title)
        {
            r_Title = i_Title;
        }

        public string Title
        {
            get
            {
                return r_Title;
            }
        }

        public void AttachObserver(ICLickedObserver i_SelectedObserver)
        {
            r_CLickedObserver.Add(i_SelectedObserver);
        }

        public void DoWhenSelected()
        {
            notifySelectedObservers();
        }

        private void notifySelectedObservers()
        {
            foreach (ICLickedObserver observer in r_CLickedObserver)
            {
                observer.Clicked();
            }
        }
    }
}
