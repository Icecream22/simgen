using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    public class Menu
    {
        public WebMenuItem Item { get; set; }
        public List<Menu> Children { get; set; }
    }


    /// <summary>
    /// 
    /// </summary>
    public class ViewMenus
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Menu> FilledSubMenuItems { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuItems"></param>
        public void Load(List<WebMenuItem> menuItems)
        {
            FilledSubMenuItems = new List<Menu>();
            foreach (WebMenuItem item in menuItems.Where((item) => { return item.ParentMenuId == "0"; }))
            {
                Menu menu = new Menu();
                menu.Item = item;
                FindSub(menu, menuItems, item);
                FilledSubMenuItems.Add(menu);
            }
        }


        /// <summary>
        /// 递归填充子菜单
        /// </summary>
        /// <param name="allMenuItem"></param>
        /// <param name="currentMenuItem"></param>
        private static void FindSub(Menu menu, List<WebMenuItem> allMenuItem, WebMenuItem currentMenuItem)
        {
            foreach (WebMenuItem item in allMenuItem)
            {
                if (item.ParentMenuId == currentMenuItem.Id.ToString())
                {
                    if (menu.Children == null)
                        menu.Children = new List<Menu>();
                    Menu subMenu = new Menu();
                    subMenu.Item = item;
                    menu.Children.Add(subMenu);
                    if (allMenuItem.Find((tempItem) => { return tempItem.ParentMenuId == item.Id.ToString(); }) != null)
                    {   
                        FindSub(subMenu, allMenuItem, item);
                    }
                }
            }

        }
    }
}
