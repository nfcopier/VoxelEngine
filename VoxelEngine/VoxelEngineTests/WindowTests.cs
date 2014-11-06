using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace VoxelEngineTests
{
    [TestClass]
    public class MainWindow
    {
        private VoxelEngine.GameWindows.MainWindow _testWindow
            = new VoxelEngine.GameWindows.MainWindow("Test Window", 1200, 750);

        [TestMethod]
        public void CanBeDisplayed()
        {
            Application.EnableVisualStyles();
            Application.Run(_testWindow);
        }

        [TestMethod]
        public void CanSetDimensions()
        {
            _testWindow.Show();
            const int width = 1000, height = 700;
            _testWindow.SetDimensions(width, height);
            Assert.AreEqual(_testWindow.Width, width);
            Assert.AreEqual(_testWindow.Height, height);
        }
    }
}
