// custom control

using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

public class StaticControl : Control
{
    private String MyText;
    private EventHandler OnTextChanged;

    public StaticControl() : base()
    {
        MyText = "Static Control";
        OnTextChanged = null;
    }

    public String ControlText
    {
        get
        {
            return MyText;
        }
        set
        {
            MyText=value;
            Invalidate();
            if(OnTextChanged != null)
            {
                OnTextChanged.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public event EventHandler TextChanged
    {
        add
        {
            OnTextChanged += value;
        }
        remove
        {
            OnTextChanged -= value;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Size textSize = Size.Round(e.Graphics.MeasureString(MyText, Font));
        float xPos = (ClientRectangle.Width/2) - (textSize.Width/2);
        float yPos = (ClientRectangle.Height/2) - (textSize.Height/2);
        e.Graphics.DrawString(MyText, Font, new SolidBrush(Color.Black), xPos, yPos);
    }
}
