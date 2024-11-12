using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Videam.Views
{
    public partial class VideoClipView : UserControl
    {
        public VideoClipView()
        {
            InitializeComponent();
        }

        private void leftThumbDragDelta(object sender, DragDeltaEventArgs e)
        {
            double newWidth = this.Width - e.HorizontalChange;

            if (newWidth > this.MinWidth)
            {
                this.Width = newWidth;
                Canvas.SetLeft(this, Canvas.GetLeft(this) + e.HorizontalChange); // Move the control to the right
            }
        }

        private void rightTHumbDragDelta(object sender, DragDeltaEventArgs e)
        {
            double newWidth = this.Width + e.HorizontalChange;

            if (newWidth > this.MinWidth)
            {
                this.Width = newWidth;
            }
        }
    }
}
