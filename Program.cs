using System;
using System.Windows.Forms;
using System.Drawing;

public class Hello : Form
{
    public Hello()
    {
        this.Paint += new PaintEventHandler(f1_paint);
        this.Size = new Size(400, 200);
        this.Text = "Hello!";
        this.BackColor = Color.Blue;
    }

    private void f1_paint(object sender, PaintEventArgs e)
    {

        // Get Graphics Object
        Graphics g = e.Graphics;

        // Method under System.Drawing.Graphics
        g.DrawString("Hello!", new Font("Verdana", 20),
        new SolidBrush(Color.White), 40, 40);

        g.DrawString("Programming is fun.", new Font("Verdana", 20),
        new SolidBrush(Color.White), 40, 75);
    }

    public static void Main()
    {
        Application.Run(new Hello());
    }

}