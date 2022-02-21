namespace Ex04.Menus.Delegates
{
    using System;

    public class MenuItem
    {
        private readonly string r_Title;

        public event Action<MenuItem> Clicked; 

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

        public void DoWhenSelected()
        {
            OnClick();
        }

        protected virtual void OnClick()
        {
            if(Clicked != null)
            {
                Clicked.Invoke(this);
            }
        }
    }
}
