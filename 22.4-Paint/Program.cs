// paint test

using System;
using System.Drawing;
using System.Windows.Forms;

public class PaintDemo : Form
{
    public PaintDemo()
    {
        this.Text = "Draw Graphics";
        this.AutoScaleBaseSize = new Size(5, 13);
        this.ClientSize = new Size(400, 100);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.FillRectangle(new SolidBrush(Color.Red), 40, 20, 300, 40);
        g.DrawString("Draw Graphics", this.Font, new SolidBrush(Color.Black), 160, 70);
    }

    public static void Main()
    {
        Application.Run(new PaintDemo());
    }
}


