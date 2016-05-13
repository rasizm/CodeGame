using MYOB.CSSInterface;
using System;

namespace Plugin
{
    public class Menus : CSSMenus
    {
        public Menus()
        {
            ProductName = "Central";
            CSSMenuItem mnuForum = Add("mnuForum", "Forum", MenuItemType.Group);
            CSSMenuItem mnuDynamic = mnuForum.Add("mnuDynamic", "Dynamic", CSSMenuItem.MenuItemType.Group);
            mnuDynamic.Add("mnuItem1", "Item 1", CSSMenuItem.MenuItemType.Item);
            mnuDynamic.DynamicMenuCallback = DynamicMenuPopup;
        }

        public override void PluginMenuClicked(object Sender, MenuEventArgs e)
        {           
        }

        private void DynamicMenuPopup(object sender, EventArgs e)
        {
        }
    }
}