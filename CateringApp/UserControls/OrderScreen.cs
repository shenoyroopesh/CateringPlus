using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Common;

namespace CateringApp.UserControls
{
    public partial class OrderScreen : UserControl
    {
        private LocalDBEntities context;
        Order order;
        OrderItemGroup group;

        public OrderScreen()
        {
            InitializeComponent();
            Resize += new EventHandler(OrderScreen_Resize);
            foreach (DataGridView d in new DataGridView[] { grdOrders, grdGroups, grdItems })
            {
                d.AutoGenerateColumns = d == grdOrders ? true : false;
                d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                d.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            InitializeData();
        }

        private void InitializeData()
        {
            //Initilize the object context
            context = new LocalDBEntities();
            grdOrders.DataSource = context.Orders.OrderByDescending(p => p.Id)
                                            .Select(p => new
                                            {
                                                p.Id,
                                                p.Customer.Name,
                                                p.Customer.ContactNo,
                                                p.Date,
                                                p.Venue
                                            });

            //load the dropdowns
            cmbCustomerName.DataSource = context.Customers;
            cmbCustomerName.DisplayMember = "Name";            
        }
        
        private void grdOrders_SelectionChanged(object sender, EventArgs e)
        {
            //show the selection in the main form
            int orderId = Convert.ToInt32(grdOrders.CurrentRow.Cells["Id"].Value);
            order = context.Orders.Where(p => p.Id == orderId).First();
            bindOrderToUI(order);
        }


        private void grdGroups_SelectionChanged(object sender, EventArgs e)
        {            
            try
            {
                group = (OrderItemGroup)grdGroups.SelectedCells[0].OwningRow.DataBoundItem;
            }
            catch { group = null; }

            if (group == null) { grdItems.DataSource = null; grdItems.Columns.Clear(); return; }

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
            order.Date = txtDate.Value.Date;
            Func<Customer> createCustomer = 
                () => { 
                    Customer c = new Customer(); 
                    c.Name = cmbCustomerName.Text;
                    context.Customers.AddObject(c);
                    return c; 
                };

            order.Customer = cmbCustomerName.SelectedValue == null ? createCustomer() : (Customer)cmbCustomerName.SelectedValue;
            order.Venue = txtVenue.Text;
            order.Customer.ContactNo = txtContactNo.Text;
            order.Note = txtNote.Text;
            context.SaveChanges(SaveOptions.AcceptAllChangesAfterSave);
            MessageBox.Show("Saved Successfully");
            InitializeData();
            grdOrders_SelectionChanged(null, null);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            order = new Order();
            bindOrderToUI(order);
            context.Orders.AddObject(order);

            cmbCustomerName.Text = "";
            txtContactNo.Text = "";
        }

        private void cmbCustomerName_TextChanged(object sender, EventArgs e)
        {
            cmbCustomerName_SelectedValueChanged(sender, e);
        }

        private void cmbCustomerName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCustomerName.SelectedValue == null) { txtContactNo.Text = ""; return; }
            txtContactNo.Text = ((Customer)cmbCustomerName.SelectedValue).ContactNo;
        }

        private void bindOrderToUI(Order order)
        {
            //bind the data to the UI controls
            lblOrderID.Text = order.Id == 0? "[New]": order.Id.ToString();
            txtVenue.Text = order.Venue;
            txtNote.Text = order.Note;

            if(order.Customer!=null) cmbCustomerName.SelectedItem = order.Customer;

            txtDate.Value = (order.Date > DateTime.MinValue && order.Date < DateTime.MaxValue) ? 
                                order.Date : DateTime.Now;

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

        void OrderScreen_Resize(object sender, EventArgs e)
        {
            orderPanel.Width = this.Width;
            orderPanel.Height = this.Height;
            itemsPanel.Width = orderPanel.Width;
            grdGroups.Width = itemsPanel.Width * 4 / 10;
            grdItems.Width = itemsPanel.Width * 4 / 10;
            btnPanel.Width = orderPanel.Width * 8 / 10;
            btnPanel.Height = btnSave.Height;
            btnSave.Left = btnSave.Parent.Width * 4 / 10;
            btnNew.Left = btnNew.Parent.Width * 6 / 10;
            grdOrders.Width = orderPanel.Width * 8 / 10;
        }

    }
}
