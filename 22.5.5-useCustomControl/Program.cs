// use custom contorl

using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

public class UseStaticControl : Form
{
    private StaticControl ctrl;
    private int ChangedTimes;

    public static int Main(string[] args)
    {
        Application.Run(new UseStaticControl());
        return 0;
    }

    public UseStaticControl()
    {
        this.Text = "Test My Control";
        ChangedTimes = 0;
        this.ClientSize = new Size(300, 200);

        ctrl = new StaticControl();
        ctrl.Location = new Point(50, 20);
        ctrl.Size = new Size(200, 40);
        ctrl.ControlText = "Test Control";
        ctrl.TabIndex = 1;
        ctrl.TextChanged += new EventHandler(OnTextChanged);
        this.Controls.Add(ctrl);

        Button cmd = new Button();
        cmd.Location = new Point(50, 100);
        cmd.Size = new Size(200, 40);
        cmd.TabIndex = 2;
        cmd.Text = "Change Static Control Text";
        cmd.Click += new EventHandler(OnClicked); 
        this.Controls.Add(cmd);
    }

    private void OnTextChanged(object sender, EventArgs e)
    {
        MessageBox.Show("The text of this static control was changed", "Event Message");
    }

    private void OnClicked(object sender, EventArgs e)
    {
        ChangedTimes++;
        ctrl.ControlText = "Changed times " + ChangedTimes.ToString();
    }
}
