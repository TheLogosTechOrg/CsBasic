// control test with events

using System.Windows.Forms;
using System.Drawing;
using System;

public class ControlsDemo : Form
{
    private Button button1;

    public ControlsDemo()
    {
        this.Text = "ControlsDemo";
        this.ClientSize = new Size(392, 117);

        button1 = new Button();
        button1.Location = new Point(256, 64);
        button1.Size = new Size(120, 40);
        button1.TabIndex = 1;
        button1.Text = "Click Me!";

        this.Controls.Add(button1);

        button1.Click += new EventHandler(button1_Click);
    }

    private void button1_Click(object sender, EventArgs evArgs)
    {
        MessageBox.Show("You clicked me!");
    }

    public static int Main(string[] args)
    {
        Application.Run(new ControlsDemo());
        return 0;
    }
}

