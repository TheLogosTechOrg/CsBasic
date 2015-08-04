// multiple events with one handler

using System;
using System.Windows.Forms;
using System.Drawing;

public class SingleHandler : Form
{
    private Button button1;
    private Button button2;

    public SingleHandler()
    {
        this.Text = "SingleHandler";
        this.ClientSize = new Size(300, 100);

        button1 = new Button();
        button1.Location = new Point(20, 50);
        button1.Size = new Size(100, 30);
        button1.TabIndex = 1;
        button1.Text = "Button One";

        button2 = new Button();
        button2.Location = new Point(180, 50);
        button2.Size = new Size(100, 30);
        button2.TabIndex = 2;
        button2.Text = "Button Two";

        this.Controls.Add(button1);
        this.Controls.Add(button2);

        button1.Click += new EventHandler(buttons_Click);
        button2.Click += new EventHandler(buttons_Click);
    }

    private void buttons_Click(object sender, EventArgs evArgs)
    {
        if (sender == button1)
        {
            MessageBox.Show("You clicked Button One!");
        }
        else if (sender == button2)
        {
            MessageBox.Show("You clicked Button Two!");
        }
    }

    public static int Main(string[] args)
    {
        Application.Run(new SingleHandler());
        return 0;
    }
}
