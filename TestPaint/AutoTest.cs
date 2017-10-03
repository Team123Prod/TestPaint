using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.Finders;
using System.Collections.Generic;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;

namespace TestPaint
{
    [TestClass]
    public class AutoTest
    {
        public Window window = null;
        
        [TestInitialize]
        public void SetUp()
        {
            string appPath = @"D:\COURSE\paint\MakePaintGreatAgain\MakePaintGreatAgain\bin\Debug\MakePaintGreatAgain.exe";
            Application application = Application.Launch(appPath);
            window = application.GetWindows()[0];
            POM.window = window;
        }

        [TestCleanup]
        public void TearDown()
        {
            window.Close();
        }

        //  --Menu--
        [TestMethod]
        public void TestExistMenuBar()
        {
            List<Menu> menues = new List<Menu> { POM.MenuBar.FileMenu, POM.MenuBar.FigureMenu, POM.MenuBar.TextMenu, POM.MenuBar.WindowMenu,
                POM.MenuBar.HelpMenu };
            foreach (Menu menu in menues)
            {
                Assert.AreEqual(true, menu.Enabled);
            }
        }
        //  --ToolBar--
        [TestMethod]
        public void TestExistToolBar()
        {
            List<Button> tools = new List<Button> { POM.ToolBar.NewWindowTool, POM.ToolBar.LoadTool, POM.ToolBar.SaveTool,
                POM.ToolBar.FColorTool, POM.ToolBar.FTypeTool, POM.ToolBar.FWidthTool};
            foreach (Button btn in tools)
            {
                Assert.AreEqual(true, btn.Enabled);
            }

        }

        //  --Plugin--
        [TestMethod]
        public void TestExistPlugin()
        {
            List<RadioButton> rBtn = new List<RadioButton> { POM.FigurePlugin.FEmpty, POM.FigurePlugin.FText, POM.FigurePlugin.FPict};
            foreach (RadioButton radio in rBtn)
            {
                Assert.AreEqual(true, radio.Enabled);
            }
        }

        //  --Property--
        [TestMethod]
        public void TestExistProperty()
        {
            List<Button> buttons = new List<Button> { POM.PropertyPlugin.FRectBtn, POM.PropertyPlugin.FLineBtn,
                POM.PropertyPlugin.FEllipseFBtn, POM.PropertyPlugin.FRRectBtn, POM.PropertyPlugin.FColorBtn,
                POM.PropertyPlugin.SaveBtn, POM.PropertyPlugin.LoadBtn};
            foreach (Button btn in buttons)
            {
                Assert.AreEqual(true, btn.Enabled);
            }

            Assert.AreEqual(true, POM.PropertyPlugin.FWidthCB.Enabled);
        }

        //  --Tab--
        [TestMethod]
        public void TestExistTabs()
        {

        }

    }
}
