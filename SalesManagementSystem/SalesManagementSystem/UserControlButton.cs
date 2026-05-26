using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    public partial class UserControlButton : PictureBox
    {
        private Image normalImage;
        private Image hoverImage;

        public UserControlButton()
        {
            InitializeComponent();

            // important: enable mouse events
            this.SizeMode = PictureBoxSizeMode.StretchImage;

            this.MouseEnter += UserControlButton_MouseEnter;
            this.MouseLeave += UserControlButton_MouseLeave;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image ImageNormal
        {
            get => normalImage;
            set
            {
                normalImage = value;
                if (Image != hoverImage) // only set if not hovering
                    Image = normalImage;
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image ImageHover
        {
            get => hoverImage;
            set => hoverImage = value;
        }

        private void UserControlButton_MouseEnter(object sender, EventArgs e)
        {
            if (hoverImage != null)
                Image = hoverImage;
        }

        private void UserControlButton_MouseLeave(object sender, EventArgs e)
        {
            if (normalImage != null)
                Image = normalImage;
        }
    }
}