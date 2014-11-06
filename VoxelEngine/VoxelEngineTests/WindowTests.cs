using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace VoxelEngineTests
{
    [TestClass]
    public class MainWindow
    {
        [TestMethod]
        public void CanBeDisplayed()
        {
            Application.EnableVisualStyles();
            Application.Run(new VoxelEngine.GameWindows.MainWindow("Test Window"));
        }
    }
}
