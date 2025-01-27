using Zadanie3;

namespace Zadanie3
{
    class Applicatoin
    {
        private GUIFactory Factory;

        public Button Button;


        public void Application(GUIFactory factory)
        {

        }

        public void CreateUI()
        {

        }

        public void Paint()
        {

        }

    }
    interface GUIFactory
    {
        Button CreateButton();
        CheackBox CreateCheackbox();
        RadioButton CreateRadioButton();
        Textbox CreateTextBox();
        Lable CreateLable();
    }
    class WinFactory : GUIFactory
    {
        public Button CreateButton()
        {
            Console.WriteLine("CreateWinButton");
            return new WinButton();
        }

        public CheackBox CreateCheackbox()
        {
            Console.WriteLine("CreateWinCheackbox");
            return new WinCheackbox();
        }

        public RadioButton CreateRadioButton()
        {
            Console.WriteLine("CreateWinRadioButton");
            return new WinRadioButton();
        }
        public Textbox CreateTextBox()
        {
            Console.WriteLine("CreateWinTextBox");
            return new WinTextbox();
        }
        public Lable CreateLable()
        {
            Console.WriteLine("CreateWinLable");
            return new WinLable();
        }


    }
    class MacFactory : GUIFactory
    {
        public Button CreateButton()
        {
            Console.WriteLine("CreateMacButton");
            return new MacButton();
        }
        public CheackBox CreateCheackbox()
        {
            Console.WriteLine("CreateMacCheackbox");
            return new MacCheackbox();
        }
        public RadioButton CreateRadioButton()
        {
            Console.WriteLine("CreateMacRadioButton");
            return new MacRadioButton();
        }
        public Textbox CreateTextBox()
        {
            Console.WriteLine("CreateMacTextBox");
            return new MacTextbox();
        }
        public Lable CreateLable()
        {
            Console.WriteLine("CreateMacLable");
            return new MacLable();
        }
    }


    class Button
    { }
    class CheackBox
    {

    }
    class RadioButton
    {

    }
    class Textbox
    {

    }
    class Lable
    {

    }

    class WinButton : Button
    {

    }
    class WinCheackbox : CheackBox
    {

    }
    class WinRadioButton : RadioButton
    {

    }
    class WinTextbox : Textbox
    {

    }
    class WinLable : Lable
    {

    }

    class MacCheackbox : CheackBox
    {

    }
    class MacButton : Button
    {

    }
    class MacRadioButton : RadioButton

    }
    class MacTextbox : Textbox
    {

    }
    class MacLable : Lable
    {

    }
}
