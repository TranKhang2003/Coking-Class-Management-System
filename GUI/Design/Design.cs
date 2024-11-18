using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

using System.Drawing;
using System.Windows.Forms;

namespace GUI.Design
{
    public class Design
    {
        public static void RoundControl(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();


            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Góc trên bên trái
            path.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90); // Góc trên bên phải
            path.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90); // Góc dưới bên phải
            path.AddArc(new Rectangle(0, control.Height - radius, radius, radius), 90, 90); // Góc dưới bên trái

            path.CloseFigure();
            control.Region = new Region(path);
        }
        public static void RoundPictureBox(PictureBox pictureBox, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(pictureBox.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(pictureBox.Width - radius, pictureBox.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, pictureBox.Height - radius, radius, radius), 90, 90);

            path.CloseFigure();
            pictureBox.Region = new Region(path);
        }
        public static void RoundControlA(Control control, int radius)
        {
            control.Paint += (sender, e) =>
            {
                GraphicsPath path = new GraphicsPath();
                path.StartFigure();

                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Góc trên bên trái
                path.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90); // Góc trên bên phải
                path.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90); // Góc dưới bên phải
                path.AddArc(new Rectangle(0, control.Height - radius, radius, radius), 90, 90); // Góc dưới bên trái

                path.CloseFigure();
                control.Region = new Region(path);
            };
        }
        public static Bitmap CreateRoundedImage(Image image, int radius)
        {
            int width = image.Width;
            int height = image.Height;
            Bitmap roundedImage = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(roundedImage))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                GraphicsPath path = new GraphicsPath();

                path.AddArc(0, 0, radius, radius, 180, 90); // Góc trên bên trái
                path.AddArc(width - radius, 0, radius, radius, 270, 90); // Góc trên bên phải
                path.AddArc(width - radius, height - radius, radius, radius, 0, 90); // Góc dưới bên phải
                path.AddArc(0, height - radius, radius, radius, 90, 90); // Góc dưới bên trái

                path.CloseFigure();
                g.SetClip(path);
                g.DrawImage(image, 0, 0, width, height);
            }

            return roundedImage;
        }

    }
}
