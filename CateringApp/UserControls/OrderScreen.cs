using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;

namespace CateringApp.UserControls
{
    public partial class OrderScreen : UserControl
    {
        private Model1Container context;
        public OrderScreen()
        {
            InitializeComponent();
            this.Resize += new EventHandler(OrderScreen_Resize);

            //Initilize the object context
            context = new Model1Container();

            try
            {
                this.grdOrders.AutoGenerateColumns = true;
                this.grdOrders.DataSource = context.Orders
                                                .Select(p => new { p.Id, p.Customer.Name, p.Date, p.Venue });
            }
            catch (EntitySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void grdOrders_SelectionChanged(object sender, EventArgs e)
        {
            //show the selection in the main form

            int orderId = Convert.ToInt32(grdOrders.CurrentRow.Cells["Id"].Value);
            var order = context.Orders.Where(p => p.Id == orderId).First();

            //bind the data to the UI controls
            lblOrderID.Text = order.Id.ToString();
            txtVenue.Text = order.Venue;
            cmbCustomerName.Text = order.Customer.Name;
            txtContactNo.Text = order.Customer.ContactNo;
            txtDate.Value = order.Date;

            grdGroups.AutoGenerateColumns = false;

            if (grdGroups.Columns.Count == 0)
            {
                DataGridViewColumn qty = new DataGridViewTextBoxColumn();
                qty.DataPropertyName = "Quantity";
                qty.HeaderText = "Quantity";

                DataGridViewColumn name = new DataGridViewTextBoxColumn();
                name.DataPropertyName = "Name";
                name.HeaderText = "Name";

                DataGridViewColumn Id = new DataGridViewTextBoxColumn();
                Id.DataPropertyName = "Id";
                Id.HeaderText = "Id";
                Id.Name = "Id";
                Id.Visible = false;


                grdGroups.Columns.Add(name);
                grdGroups.Columns.Add(qty);
                grdGroups.Columns.Add(Id);   
            }  

            grdGroups.DataSource = order.OrderItemGroups;
        }


        private void grdGroups_SelectionChanged(object sender, EventArgs e)
        {
            int itemGroupId = Convert.ToInt32(grdGroups.CurrentRow.Cells["Id"].Value);
            var group = context.OrderItemGroups.Where(p => p.Id == itemGroupId).First();

            grdItems.AutoGenerateColumns = false;

            if (grdItems.Columns.Count == 0)
            {
                DataGridViewColumn name = new DataGridViewTextBoxColumn();
                name.DataPropertyName = "Name";
                name.HeaderText = "Name";

                grdItems.Columns.Add(name);
            }

            grdItems.DataSource = group.OrderItems;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges(SaveOptions.AcceptAllChangesAfterSave);
        }

        void OrderScreen_Resize(object sender, EventArgs e)
        {
            orderPanel.Width = this.Width;
            orderPanel.Height = this.Height;

            itemsPanel.Width = orderPanel.Width;

            grdGroups.Width = itemsPanel.Width * 4 / 10;
            grdItems.Width = itemsPanel.Width * 4 / 10;

            btnPanel.Width = orderPanel.Width * 8 / 10;
            btnPanel.Height = btnSave.Height;

            btnSave.Left = (btnSave.Parent.Width - btnSave.Width) / 2;

            grdOrders.Width = orderPanel.Width * 8 / 10;
        }

       

    }
}
