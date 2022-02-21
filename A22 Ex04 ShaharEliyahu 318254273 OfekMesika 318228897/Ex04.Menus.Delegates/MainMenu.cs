namespace Ex04.Menus.Delegates
{
    using System;
    using System.Collections;

    public class MainMenu
    {
        private readonly Stack r_MenuItemsStack = new Stack();
        private readonly SubMenu r_SubMenu;
        private bool m_KeepRunning;

        public MainMenu(string i_Title)
        {
            r_SubMenu = new SubMenu(i_Title);
            r_MenuItemsStack.Push(r_SubMenu);
            r_SubMenu.Clicked += Click;
            m_KeepRunning = true;
        }

        public SubMenu SubMenu
        {
            get
            {
                return r_SubMenu;
            }
        }

        public SubMenu AddSubMenu(int i_Index, string i_Text, SubMenu i_UpperMenu)
        {
            SubMenu subMenu = new SubMenu(i_Text);

            i_UpperMenu.AddSubMenuToDictionary(i_Index, subMenu);
            r_SubMenu.Clicked += Click;

            return subMenu;
        }

        private void getUserChoice(int i_MaxValueToEnter)
        {
            string message = string.Format(
                "Enter your request: (1 to {0} or press '0' to {1}).", 
                i_MaxValueToEnter, 
                (r_MenuItemsStack.Count == 1) ? "Exit" : "Back");

            Console.WriteLine(message);
            int inputNumber = checkUserInputValid(i_MaxValueToEnter);

            if (inputNumber == 0)
            {
                pressBackButton();
            }
            else
            {
                SubMenu subMenuInStack = r_MenuItemsStack.Peek() as SubMenu;

                r_MenuItemsStack.Push(subMenuInStack.SubMenus[inputNumber]);
                subMenuInStack.SubMenus[inputNumber].DoWhenSelected();
            }
        }

        private void pressBackButton()
        {
            r_MenuItemsStack.Pop();
            if (r_MenuItemsStack.Count == 0)
            {
                m_KeepRunning = false;
            }
        }

        private int checkUserInputValid(int i_MaxValueToEnter)
        {
            int inputNumber = 0;
            string userInput = Console.ReadLine();
            bool found = false;

            while (!found)
            {
                if (int.TryParse(userInput, out inputNumber))
                {
                    if (inputNumber > i_MaxValueToEnter || inputNumber < 0)
                    {
                        Console.WriteLine($"Enter number between 0 to {i_MaxValueToEnter}");
                        userInput = Console.ReadLine();
                    }
                    else
                    {
                        found = true;
                    }
                }
                else
                {
                    Console.WriteLine($"Enter number between 0 to {i_MaxValueToEnter}");
                    userInput = Console.ReadLine();
                }
            }

            return inputNumber;
        }

        public void Show()
        {
            string message;

            while (m_KeepRunning)
            {
                Console.Clear();
                if (!(r_MenuItemsStack.Peek() is SubMenu))
                {
                    r_MenuItemsStack.Pop();
                }

                SubMenu subMenuInStack = r_MenuItemsStack.Peek() as SubMenu;
                
                message = string.Format(
                    @"** {0} **
_ _ _ _ _ _ _ _ _ _ _ _ _ _ ", 
                    subMenuInStack.Title);

                Console.WriteLine(message);
                subMenuInStack.PrintDictionary();
                message = string.Format(
                    @"{0}
_ _ _ _ _ _ _ _ _ _ _ _ _ _ ", 
                    r_MenuItemsStack.Count > 1 ? "0 -> Back" : "0 -> Exit");
                
                Console.WriteLine(message);
                getUserChoice(subMenuInStack.SubMenus.Count);
            }
        }

        public void Click(MenuItem i_MenuItem)
        {
            Show();
        }
    }
}
