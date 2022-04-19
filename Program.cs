using System.Drawing;
using Bitmap bmp = new(1600, 1080);
using Graphics gfx = Graphics.FromImage(bmp);
using Pen pen = new(Color.Yellow);

gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
gfx.Clear(Color.Navy);

Random rand = new(0);

for (int i = 0; i < 1500; i++)
{
    pen.Color = Color.FromKnownColor(KnownColor.Red);  
    Point pt1 = new(rand.Next(bmp.Width), rand.Next(bmp.Height));
    Point pt2 = new(rand.Next(bmp.Width), rand.Next(bmp.Height));
    gfx.DrawLine(pen, pt1, pt2);
}


bmp.Save("demo.png");