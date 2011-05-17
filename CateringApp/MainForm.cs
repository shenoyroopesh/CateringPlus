using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CateringApp.UserControls;

namespace CateringApp
{
    /// <summary>
    /// This is the main Form used in the application
    /// </summary>
    public partial class MainForm : Form
    {
        public static Color DEFAULT_BACKGROUND = Color.White;
        List<menuMap> menuItems = new List<menuMap>();

        /// <summary>
        /// Constructor of the main form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();            
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            setFonts();

            //initialize menu items 
            menuItems.Add(new menuMap(new ToolStripMenuItem("Order"), new OrderScreen(), Color.Beige));
            menuItems.Add(new menuMap(new ToolStripMenuItem("Billing"), new BillingScreen(), Color.AliceBlue));            
            menuItems.Add(new menuMap(new ToolStripMenuItem("Receipt"), new ReceiptScreen(), Color.Bisque));

            /* *****************
             * LAYOUT SECTION
             * ******************/

            //layout specific code
            mainFormContainer.SplitterDistance = (int)(this.Width * 0.7);

            //layout the menu and link them to the user controls
            foreach (menuMap map in menuItems)
            {
                UserControl uc = map.userControl;
                Color color = map.color;
                ToolStripMenuItem item = map.menuItem;
                menuStrip1.Items.Add(map.menuItem);
                map.menuItem.Click += new EventHandler(delegate (Object o, EventArgs e) {
                    OnMenuClick(uc, color, item);
                });
            }

            this.Resize += new EventHandler(MainForm_Resize);


            /* ***************
             * INITIALIZE THE FORM
             * *************** */

            //by default call the first menu item
            OnMenuClick(menuItems.First().userControl, menuItems.First().color, menuItems.First().menuItem);

            /* ****************
             * BACKGROUND COLOR
             * *****************/

            mainFormContainer.Panel2.BackColor = DEFAULT_BACKGROUND;
            mainFormContainer.BackColor = DEFAULT_BACKGROUND;
            menuStrip1.BackColor = DEFAULT_BACKGROUND;
        }

        //this is public since it can be called from within the user controls too, whenever they are reloaded
        public void setFonts()
        {            
            Font font = new Font(SystemFonts.MessageBoxFont.FontFamily, 12);
            this.Font = font;
            menuStrip1.Font = font;
            setChildFont(this, font);
        }

        /// <summary>
        /// Iteratively applies the font style to each child control
        /// </summary>
        /// <param name="uc"></param>
        /// <param name="font"></param>
        private void setChildFont(Control uc, Font font)
        {
            foreach (Control c in uc.Controls)
            {
                c.Font = font;            
                setChildFont(c, font);
            }
        }


        void MainForm_Resize(object sender, EventArgs e)
        {
            SplitterPanel pnl = mainFormContainer.Panel1;
            //resize the first control inside panel1
            pnl.Controls[0].Width = pnl.Width;
            pnl.Controls[0].Height = pnl.Height;
        }

        /// <summary>
        /// Called when a menu item is clicked
        /// </summary>
        /// <param name="uc"></param>
        /// <param name="color"></param>
        /// <param name="item"></param>
        private void OnMenuClick(UserControl uc, Color color, ToolStripMenuItem item)
        {
            mainFormContainer.Panel1.Controls.Clear();
            uc.BackColor = color;
            menuItems.ForEach(p => p.menuItem.BackColor = DEFAULT_BACKGROUND);
            item.BackColor = color;
            mainFormContainer.Panel1.Controls.Add(uc);
            uc.Width = mainFormContainer.Panel1.Width;
            uc.Height = mainFormContainer.Panel1.Height;
        }

        /// <summary>
        /// This class is used to map together menuItem, the user control called by that menu item and the color
        /// applied to that particular user control.
        /// </summary>
        public class menuMap
        {
            public ToolStripMenuItem menuItem { get; set; }
            public UserControl userControl { get; set; }
            public Color color { get; set; }
            public menuMap(ToolStripMenuItem menuItem, UserControl userControl, Color color)
            {
                this.menuItem = menuItem;
                this.userControl = userControl;
                this.color = color;
            }
        }
    }
}
