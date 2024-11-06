using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

using System.Drawing;
using System.Windows.Forms;

namespace CookingClassManagementSystem.Design
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

    }
}
