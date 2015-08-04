// windows forms from console

//using System.WinForms;
using System.Windows.Forms;

public class SimpleHello : Form
{
    public SimpleHello()
    {
        this.Text = "Hello, Windows Forms!";
    }

    public static int Main(string[] args)
    {
        Application.Run(new SimpleHello());
        return 0;
    }
}
