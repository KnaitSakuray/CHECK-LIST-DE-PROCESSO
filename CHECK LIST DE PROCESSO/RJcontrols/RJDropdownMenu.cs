using LED_EPL.RJcontrols.Desing;
using LED_EPL.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED_EPL.RJcontrols
{
    public class RJDropdownMenu : ContextMenuStrip
    {
        /// <summary>
        /// This class inherits from the ContextMenuStrip class.
        /// To customize the appearance of this control use the classes:
        /// <see cref="DropdownMenuColors"/> and <see cref="DropdownMenuRenderer"/>
        /// It also helps you to position the control in an easier way thanks
        /// to the <see cref="DropdownMenuPosition"/> enumeration.
        /// </summary>
        /// 

        #region -> Fields

        private bool ownerIsMenuButton; ///Sets or Gets if dropdown owns to main form side menu <see cref="RJMenuButton"/>
        private bool activeMenuItem;/// Sets or Gets if MenuItem is Activated (it has an associated form, the item menu will remain highlighted when the form is active)
        private Bitmap menuItemIcon;//Sets or Gets the menu item icon, Also it sets the height of the menu item
        #endregion

        #region -> Constructors

        public RJDropdownMenu()
        {
            this.Renderer = new DropdownMenuRenderer(ownerIsMenuButton);//Set the custom renderer and send ownerIsMenuButton value
            this.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));//Set default font           
        }
        //
        // Summary:
        //     Initializes a new instance of the RJDropdownMenu class
        //     and associates it with the specified container.
        //
        // Parameters:
        //   container:
        //     A component that implements System.ComponentModel.IContainer that is the
        //     container of the System.Windows.Forms.ContextMenuStrip.
        public RJDropdownMenu(IContainer container)//This constructor is invoked automatically in the form designer when the control is dragged from the toolbox onto the form.
            : base(container)////This constructor ensures that the object is removed correctly, since it is not a child of the form.
        {
            this.Renderer = new DropdownMenuRenderer(ownerIsMenuButton);//Set the custom renderer and send ownerIsMenuButton value
            this.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));//Set default font           
        }
        #endregion

        #region -> Properties
        [Browsable(false)]
        public bool OwnerIsMenuButton
        {
            get { return ownerIsMenuButton; }
            set
            {
                ownerIsMenuButton = value;
                this.Renderer = new DropdownMenuRenderer(ownerIsMenuButton);//Set the custom renderer and send ownerIsMenuButton value                       
            }
        }
        [Browsable(false)]
        public bool ActiveMenuItem
        {
            get { return activeMenuItem; }
            set { activeMenuItem = value; }
        }
        #endregion

        #region -> Private methods

        private void ApplyAppearanceSettings()
        {
            //- Set the height of the menu item and the width of the left column of the drop-down menu using the image property of the menu item.
            if (OwnerIsMenuButton == true)//If the owner is menubutton
                menuItemIcon = new Bitmap(25, 45);//Set 25px in width and 45px in HEIGHT 
            else //Default value
                menuItemIcon = new Bitmap(22, 25);//Set 22px in width and  25px in HEIGHT 

            //- Set setting text color and adjust menu item image (Icon)
            #region - Dropdown Menu Item Level 1 ---------------------------------------------

            foreach (ToolStripMenuItem menuItemL1 in this.Items)
            {
                menuItemL1.ImageScaling = ToolStripItemImageScaling.None;//Do not scale image

                if (UIAppearance.Theme == UITheme.Dark || this.OwnerIsMenuButton == true)//If the theme is dark  or the owner is menubutton set the text color of the dark style theme
                {
                    //If the item menu is activated do not apply the text color to keep the highlighting
                    if (!ActiveMenuItem) menuItemL1.ForeColor = RJColors.DarkTextColor;
                }
                else //If the theme is light set the text color of the light theme- //If the item menu is activated do not apply the text color
                    if (!ActiveMenuItem) menuItemL1.ForeColor = RJColors.LightTextColor;

                if (menuItemL1.Image == null)//If no image is set in menu item, set no-image bitmap(menuItemIcon) to keep the previously defined height and width
                    menuItemL1.Image = menuItemIcon;//set no-image bitmap
                else//if an image has been set in the menu item, readjust the image to keep the previously defined height and whidht(Limit widht of left colum and heifht of menu item)
                    menuItemL1.Image = RedrawMenuItemIcon(menuItemL1.Image);//Redraw menu item icon
                #endregion ---------------------------------------------

                #region - Dropdown Menu Item Level 2 ---------------------------------------------

                foreach (ToolStripMenuItem menuItemL2 in menuItemL1.DropDownItems)
                {
                    menuItemL2.ImageScaling = ToolStripItemImageScaling.None;

                    if (UIAppearance.Theme == UITheme.Dark || this.OwnerIsMenuButton == true)
                    {
                        if (!ActiveMenuItem) menuItemL2.ForeColor = RJColors.DarkTextColor;
                    }
                    else
                        if (!ActiveMenuItem) menuItemL2.ForeColor = RJColors.LightTextColor;

                    if (menuItemL2.Image == null) menuItemL2.Image = menuItemIcon;
                    else menuItemL2.Image = RedrawMenuItemIcon(menuItemL2.Image);
                    #endregion ---------------------------------------------

                    #region - Dropdown Menu Item Level 3 ---------------------------------------------

                    foreach (ToolStripMenuItem menuItemL3 in menuItemL2.DropDownItems)
                    {
                        menuItemL3.ImageScaling = ToolStripItemImageScaling.None;

                        if (UIAppearance.Theme == UITheme.Dark || this.OwnerIsMenuButton == true)
                        {
                            if (!ActiveMenuItem) menuItemL3.ForeColor = RJColors.DarkTextColor;
                        }
                        else
                            if (!ActiveMenuItem) menuItemL3.ForeColor = RJColors.LightTextColor;

                        if (menuItemL3.Image == null) menuItemL3.Image = menuItemIcon;
                        else menuItemL3.Image = RedrawMenuItemIcon(menuItemL3.Image);
                        #endregion ---------------------------------------------

                        #region - Dropdown Menu Item Level 4 ---------------------------------------------

                        foreach (ToolStripMenuItem menuItemL4 in menuItemL3.DropDownItems)
                        {
                            menuItemL4.ImageScaling = ToolStripItemImageScaling.None;

                            if (UIAppearance.Theme == UITheme.Dark || this.OwnerIsMenuButton == true)
                            {
                                if (!ActiveMenuItem) menuItemL4.ForeColor = RJColors.DarkTextColor;
                            }
                            else
                                if (!ActiveMenuItem) menuItemL4.ForeColor = RJColors.LightTextColor;

                            if (menuItemL4.Image == null) menuItemL4.Image = menuItemIcon;
                            else menuItemL4.Image = RedrawMenuItemIcon(menuItemL4.Image);

                        }
                        #endregion ---------------------------------------------
                    }
                }
            }
        }
        private Image RedrawMenuItemIcon(Image itemImage)
        {//this method will resize and center the image of the menu item

            var newItemIcon = new Bitmap(menuItemIcon.Width, menuItemIcon.Height);//Create a new bitmap with the dimensions specified previously.

            if (itemImage.Size.Width > newItemIcon.Size.Width)//if the size of the item image is larger than the specified icon image
                itemImage = new Bitmap(itemImage, new Size(newItemIcon.Width - 1, newItemIcon.Width - 1));//Resize the image subtracting 1 to apply padding.

            //Get centered position
            int locX = (menuItemIcon.Width - itemImage.Width) / 2;
            int locY = (menuItemIcon.Height - itemImage.Height) / 2;

            using (Graphics graphic = Graphics.FromImage(newItemIcon))//draw the image resized and centered on the created bitmap newItemIcon
            {
                graphic.DrawImage(itemImage, locX, locY);
            };
            return newItemIcon;//Return new item icon
        }
        #endregion

        #region -> Overridden methods

        public void Show(Control ownerControl, DropdownMenuPosition position)
        { //this method helps you to display and position drop down menu more quickly

            ApplyAppearanceSettings();//Load setting

            int x = 0;
            int y = 0;

            switch (position)
            {
                case DropdownMenuPosition.LeftTop:
                    x = 0 - this.Width;
                    y = 0;
                    break;
                case DropdownMenuPosition.LeftBottom:
                    x = 0;
                    y = ownerControl.Height;
                    break;
                case DropdownMenuPosition.TopRight:
                    x = ownerControl.Width;
                    y = 0;
                    break;
                case DropdownMenuPosition.BottomRight:
                    x = ownerControl.Width - this.Width;
                    y = ownerControl.Height;
                    break;

            }
            this.Show(ownerControl, x, y); //send values to show dropdown menu
        }

        public new void Show()
        {
            ApplyAppearanceSettings();
            base.Show();
        }
        public new void Show(Point screenLocation)
        {
            ApplyAppearanceSettings();
            base.Show(screenLocation);
        }
        public new void Show(int x, int y)
        {
            ApplyAppearanceSettings();
            base.Show(x, y);
        }
        public new void Show(Point position, ToolStripDropDownDirection direction)
        {
            ApplyAppearanceSettings();
            base.Show(position, direction);
        }
        public new void Show(Control ownerControl, Point position)
        {
            ApplyAppearanceSettings();
            base.Show(ownerControl, position);
        }
        public new void Show(Control ownerControl, int x, int y)
        {
            ApplyAppearanceSettings();
            base.Show(ownerControl, x, y);
        }
        public new void Show(Control ownerControl, Point position, ToolStripDropDownDirection direction)
        {
            ApplyAppearanceSettings();
            base.Show(ownerControl, position, direction);
        }
        #endregion
    }
}
