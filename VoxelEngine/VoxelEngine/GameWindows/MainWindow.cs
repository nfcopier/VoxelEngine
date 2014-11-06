using System.Drawing;
using System.Windows.Forms;

namespace VoxelEngine.GameWindows
{
    public class MainWindow : Form
    {
        public MainWindow(string text)
        {
            this.Text = text;
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public void SetDimensions(int width, int height)
        {
            var workingArea = Screen.PrimaryScreen.WorkingArea;
            var left = (workingArea.Width - width) / 2;
            var top = (workingArea.Height - height) / 2;
            this.Left = left;
            this.Top = top;
            this.Width = width;
            this.Height = height;
        }
    }
}
