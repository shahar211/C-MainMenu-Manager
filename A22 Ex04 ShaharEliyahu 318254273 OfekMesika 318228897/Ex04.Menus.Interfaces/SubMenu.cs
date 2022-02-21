namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;

    public class SubMenu : MenuItem
    {
        private readonly Dictionary<int, MenuItem> r_SubMenus;

        public SubMenu(string i_Title)
            : base(i_Title)
        {
            r_SubMenus = new Dictionary<int, MenuItem>();
        }

        public bool AddSubMenuToDictionary(int i_Index, MenuItem i_ItemToAdd)
        {
            bool found = false;
            if (!r_SubMenus.ContainsKey(i_Index))
            {
                r_SubMenus.Add(i_Index, i_ItemToAdd);
                found = true;
            }

            return found;
        }

        public Dictionary<int, MenuItem> SubMenus
        {
            get
            {
               return r_SubMenus;
            }
        }

        public MenuItem AddMenuItem(int i_Index, string i_Text)
        {
            MenuItem menuItem = new MenuItem(i_Text);

            AddSubMenuToDictionary(i_Index, menuItem);

            return menuItem;
        }

        public void PrintDictionary()
        {
            foreach (KeyValuePair<int, MenuItem> kvp in r_SubMenus)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Title}");
            }
        }
    }
}
