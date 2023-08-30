using System.Drawing;
using System.Windows.Forms;

namespace Menu
{
    public class ImageForm : Form
    {
        private PictureBox _pictureBox;

        public ImageForm(Image image)
        {
            InitializeComponent();
            _pictureBox.Image = image;
        }

        private void InitializeComponent()
        {
            this._pictureBox = new PictureBox();
            this.SuspendLayout();
            
            // pictureBox
            this._pictureBox.Dock = DockStyle.Fill;
            this._pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            
            // ImageForm
            this.ClientSize = new Size(600, 400);  // Укажите желаемые размеры формы
            this.Controls.Add(this._pictureBox);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Изображение";
            this.ResumeLayout(false);
        }
    }
}