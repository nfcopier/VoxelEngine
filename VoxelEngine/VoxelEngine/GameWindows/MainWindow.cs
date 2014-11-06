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
    }
}
