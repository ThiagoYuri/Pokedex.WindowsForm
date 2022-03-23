using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Pokedex.WindowsForm.Forms.CustomizedView
{
    public class PictureBoxWithRadius : PictureBox
    {
        /// <summary>
        /// Picture box Possible radius and border
        /// </summary>
        private int borderSize = 0;
        private int borderRadius = 0;
        private bool[] borderCreated = { true, true, true, true }; 
        private Color borderColor = Color.Aqua;

        [Category("Border")]
        public bool[] BorderCreated { get => borderCreated; set { borderCreated = value; this.Invalidate(); } }


        [Category("Border")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        [Category("Border")]
        public int BorderRadius { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }
        [Category("Border")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }



        public PictureBoxWithRadius()
        {
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumAquamarine;
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
                //create draw
                path.AddArc(rect.X, rect.Y, (BorderCreated[0])?radius: 0.01F, radius, 180, 90);
                path.AddArc(rect.Width - radius, rect.Y, radius, (BorderCreated[1]) ? radius : 0.01F, 270, 90);
                path.AddArc(rect.Width - ((BorderCreated[2]) ? radius : 0), rect.Height - ((BorderCreated[2]) ? radius : 0), (BorderCreated[2]) ? radius : 0.01F, (BorderCreated[2]) ? radius : 0.01F, 0, 90); 
                path.AddArc(rect.X, rect.Height - radius, (BorderCreated[3]) ? radius : 0.01F, radius, 90, 90);   
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF reactSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF reactBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1);

            if (borderRadius > 1)
            {
                using (GraphicsPath pathSurface = GetFigurePath(reactSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(reactBorder, borderRadius ))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pe.Graphics.DrawPath(penSurface, pathSurface);
                    if (borderSize >= 1)
                        pe.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                this.Region = new Region(reactSurface);
                if(borderSize>= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pe.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);

                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {           
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
