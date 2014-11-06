using System.Windows.Forms;
using VoxelEngine.GameWindows;

namespace VoxelEngine
{
    public static class AppStart
    {
        private static MainWindow _mainWindow;
        public static void Main()
        {
            _mainWindow = new MainWindow("Voxel Engine");
            Application.EnableVisualStyles();
            Application.Run(_mainWindow);
        }
    }
}
