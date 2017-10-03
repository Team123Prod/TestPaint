using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowStripControls;
using TestStack.White.UIItems.TabItems;
using TestStack.White.Factory;

namespace TestPaint
{
    public class POM
    {
        public static Window window { get; set; }

        public static class MenuBar
        {
            public static Menu FileMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("File"));
            public static Menu FigureMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Figure"));
            public static Menu TextMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Text"));
            public static Menu WindowMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Window"));
            public static Menu HelpMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Help"));
            //for Submenu
            public static Menu SSaveMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("File")).SubMenu("Save");
            public static Menu SLoadMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("File")).SubMenu("Load");
            public static Menu SSaveCloudMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("File")).SubMenu("Save to cloud");
            public static Menu SLoadCloudMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("File")).SubMenu("Load to cloud");
            public static Menu SSaveSetMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("File")).SubMenu("Save settings to");
            public static Menu SLoadSetMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("File")).SubMenu("Load settings from");
            public static Menu SExitMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("File")).SubMenu("Exit");
            public static Menu SColorMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Figure")).SubMenu("Color");
            public static Menu STypeMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Figure")).SubMenu("Type");
            public static Menu SWidthMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Figure")).SubMenu("TypeWidth");
            public static Menu SFontMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Text")).SubMenu("Text Font");
            public static Menu SSizeMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Text")).SubMenu("Text Size");
            public static Menu SAlignMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Text")).SubMenu("Text Align");
            public static Menu SColorTxtMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Text")).SubMenu("Text Color");
            public static Menu SAddTabMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Window")).SubMenu("Add tab");
            public static Menu SDalTabMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Window")).SubMenu("Delete tab");
            public static Menu SNameTabMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Window")).SubMenu("Rename tab");
            public static Menu SSkinMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Help")).SubMenu("Skin");
            public static Menu SLangMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Help")).SubMenu("Language");
            public static Menu SHelpMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Help")).SubMenu("Help");
            public static Menu SAboutMenu => window.MenuBar.MenuItemBy(SearchCriteria.ByText("Help")).SubMenu("About");

        }

        public static class ToolBar
        {
            public static Button NewWindowTool => window.ToolStrip.Get<Button>(SearchCriteria.ByText("New Window"));
            public static Button LoadTool => window.ToolStrip.Get<Button>(SearchCriteria.ByText("Load"));
            public static Button SaveTool => window.ToolStrip.Get<Button>(SearchCriteria.ByText("Save"));
            public static Button FTypeTool => window.ToolStrip.Get<Button>(SearchCriteria.ByText("Type")); 
            public static Button FWidthTool => window.ToolStrip.Get<Button>(SearchCriteria.ByText("Width"));
            public static Button FColorTool => window.ToolStrip.Get<Button>(SearchCriteria.ByText("Color"));

        }
        public static class FigurePlugin
        {
            public static RadioButton FEmpty => window.Get<RadioButton>(SearchCriteria.ByAutomationId("rBtnEmptyFig"));
            public static RadioButton FText => window.Get<RadioButton>(SearchCriteria.ByAutomationId("rBtnFigText"));
            public static RadioButton FPict => window.Get<RadioButton>(SearchCriteria.ByAutomationId("rBtnFigPict"));
        }
        public static class PropertyPlugin
        {
            public static Button FRectBtn => window.Get<Button>(SearchCriteria.ByAutomationId("btnRect"));
            public static Button FLineBtn => window.Get<Button>(SearchCriteria.ByAutomationId("btnLine"));
            public static Button FEllipseFBtn => window.Get<Button>(SearchCriteria.ByAutomationId("btnEllipse"));
            public static Button FRRectBtn => window.Get<Button>(SearchCriteria.ByAutomationId("btnRRect"));
            public static Button FColorBtn => window.Get<Button>(SearchCriteria.ByAutomationId("btnColor"));
            public static ComboBox FWidthCB => window.Get<ComboBox>(SearchCriteria.ByAutomationId("cboxWidth"));
            public static Button SaveBtn => window.Get<Button>(SearchCriteria.ByAutomationId("btnSave"));
            public static Button LoadBtn => window.Get<Button>(SearchCriteria.ByAutomationId("btnLoad"));
            public static TextBox TxtSet => window.Get<TextBox>(SearchCriteria.ByAutomationId("setText"));
            public static ComboBox TxtFont => window.Get<ComboBox>(SearchCriteria.ByAutomationId("cboxFontTxt"));
            public static ComboBox TxtSize => window.Get<ComboBox>(SearchCriteria.ByAutomationId("cboxSizeTxt"));
            public static ComboBox TxtAlign => window.Get<ComboBox>(SearchCriteria.ByAutomationId("cboxAlignTxt"));

        }
        public static class Tabs
        {

        }

        public static class StatusBar
        {
            
        }


    }
}
