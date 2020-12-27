using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ColourToTransparency
{
    public class NoInterpPicturebox : PictureBox
    {

        [Category("Behaviour")]
        [DefaultValue(InterpolationMode.NearestNeighbor)]
        public InterpolationMode InterpolationMode = InterpolationMode.NearestNeighbor;

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.InterpolationMode = InterpolationMode;
            pe.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            base.OnPaint(pe);
        }
    }
}
