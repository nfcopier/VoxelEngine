using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace VoxelEngine.GameWindows
{
    public class MainWindow : Form
    {
        public MainWindow(string text)
        {
            this.Text = text;
            var appFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/VoxelEngine/";
            if (File.Exists(appFolder + "MainWindow.ico"))
            {
                this.Icon = new Icon(appFolder + "MainWindow.ico");
            }
        }
        public MainWindow(string text, int width, int height)
            : this(text)
        {
            this.SetDimensions(width, height);
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
            this.Bounds = new Rectangle(left, top, width, height);
        }
    }
}
