// menu test

using System;
using System.Drawing;
using System.Windows.Forms;

public class MainMenuDemo : Form
{
    public MainMenuDemo()
    {
        MainMenu mainMenu = new MainMenu();
        this.Menu = mainMenu;
        MenuItem miFile = mainMenu.MenuItems.Add("文件(&F)");

        MenuItem miTxt = new MenuItem("文本(&T)", new EventHandler(this.MenuCommand), Shortcut.CtrlT);
        MenuItem miBmp = new MenuItem("位图(&B)", new EventHandler(this.MenuCommand), Shortcut.CtrlB);
        MenuItem miAni = new MenuItem("动画(&A)", new EventHandler(this.MenuCommand), Shortcut.CtrlA);
        miFile.MenuItems.Add("新建(&N)", (new MenuItem[] { miTxt, miBmp, miAni }));

        MenuItem miOpen = new MenuItem("打开(&O)...", new EventHandler(this.MenuCommand), Shortcut.CtrlO);
        miFile.MenuItems.Add(miOpen);

        miFile.MenuItems.Add("-"); // seperator

        MenuItem miExit = new MenuItem("退出(&X)", new EventHandler(this.MenuCommand), Shortcut.CtrlX);
        miFile.MenuItems.Add(miExit);

        ContextMenu contextMenu = new ContextMenu();
        this.ContextMenu = contextMenu;
        contextMenu.MenuItems.Add("新建(&N)", (new MenuItem[] { miTxt, miBmp, miAni }));
        contextMenu.MenuItems.Add(miOpen);
        contextMenu.MenuItems.Add("-"); // seperator
        contextMenu.MenuItems.Add(miExit);
    }

    private void MenuCommand(object sender, System.EventArgs e)
    {
        MenuItem miClicked = (MenuItem)sender;
        String MenuItemText = miClicked.Text;
        if (MenuItemText == "退出(&X)")
        {
            this.Close();
        }
        else
        {
            MessageBox.Show("This function havs not been implemented", "Not Implemented");
        }
    }

    public static void Main()
    {
        Application.Run(new MainMenuDemo());
    }
}


