﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;


namespace PaletizadoraV1._0
{
    public class DropMenu : ContextMenuStrip
    {
        private bool isMainMenu;
        private int menuItemHeight = 25;
        private Color menuItemTextColor = Color.DimGray;
        private Color primaryColor = Color.MediumSlateBlue;

        private Bitmap menuItemHeaderSize;

        public DropMenu(IContainer container)
            : base(container)
        {

        }

        public bool IsMainMenu { get => isMainMenu; set => isMainMenu = value; }
        public int MenuItemHeight { get => menuItemHeight; set => menuItemHeight = value; }
        public Color MenuItemTextColor { get => menuItemTextColor; set => menuItemTextColor = value; }
        public Color PrimaryColor { get => primaryColor; set => primaryColor = value; }

        private void LoadMenuItemAppearance()
        {
            if(isMainMenu)
            {
                menuItemHeaderSize = new Bitmap(52, 45);
                menuItemTextColor = Color.Gainsboro;
            }
            else
            {
                menuItemHeaderSize = new Bitmap(15, menuItemHeight);
            } 
                foreach(ToolStripMenuItem menuItemL1 in this.Items)
            {
                menuItemL1.ForeColor = menuItemTextColor;
                menuItemL1.ImageScaling = ToolStripItemImageScaling.None;
                if (menuItemL1.Image == null) menuItemL1.Image = menuItemHeaderSize;
                foreach (ToolStripMenuItem menuItemL2 in menuItemL1.DropDownItems)
                {
                    menuItemL2.ForeColor = menuItemTextColor;
                    menuItemL2.ImageScaling = ToolStripItemImageScaling.None;
                    if (menuItemL2.Image == null) menuItemL2.Image = menuItemHeaderSize;
                    foreach (ToolStripMenuItem menuItemL3 in menuItemL2.DropDownItems)
                    {
                        menuItemL3.ForeColor = menuItemTextColor;
                        menuItemL3.ImageScaling = ToolStripItemImageScaling.None;
                        if (menuItemL3.Image == null) menuItemL3.Image = menuItemHeaderSize;
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if(this.DesignMode == false)
            {
                LoadMenuItemAppearance();
                this.Renderer = new MenuRender(IsMainMenu, primaryColor, menuItemTextColor);
            }
        }
    
    }
}
