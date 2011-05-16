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
    public partial class BillingScreen : UserControl
    {
        private Bill bill; //current bill
        private LocalDBEntities context;

        public BillingScreen()
        {
            InitializeComponent();
            foreach (DataGridView d in new DataGridView[] { grdBills, grdBillLines })
            {
                d.AutoGenerateColumns = true;
                d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                d.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            InitializeData();

            this.ParentChanged += new EventHandler(BillingScreen_ParentChanged);
        }

        void BillingScreen_ParentChanged(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void InitializeData()
        {
            //Initilize the object context
            context = new LocalDBEntities();
            grdBills.DataSource = context.Bills.OrderByDescending(p => p.Id)
                                            .Select(p => new
                                            {
                                                p.Id,
                                                Customer = p.Order.Customer.Name,
                                                Total = p.BillLines.Count == 0? 0: p.BillLines.Select(b => b.Amount).Sum()
                                            });

            //load the dropdowns
            cmbOrderNo.DataSource = context.Orders.Where(p => p.Bills.Count == 0);
            cmbOrderNo.DisplayMember = "Id";
        }

        private void BillingScreen_Resize(object sender, EventArgs e)
        {
            mainContainer.Width = mainContainer.Parent.Width * 9 / 10;
            tableLayoutPanel1.Width = mainContainer.Width;
            tableLayoutPanel2.Width = mainContainer.Width;
            grdBillLines.Width = mainContainer.Width;
            grdBills.Width = mainContainer.Width;
            btnPanel.Width = mainContainer.Width;
            btnSave.Left = mainContainer.Width * 2 / 10;
            btnPrint.Left = mainContainer.Width * 4 / 10;
            btnNew.Left = mainContainer.Width * 6 / 10;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bill = new Bill();            
            bill.Date = DateTime.Now.Date;
            context.Bills.AddObject(bill);
            bindBillToUI(bill);
            cmbOrderNo.Text = "";            
        }

        private void bindBillToUI(Bill bill)
        {
            lblBillNoValue.Text = bill.Id == 0 ? "[New]" : bill.Id.ToString();            
            if (bill.Order != null)
            {
                grdBillLines.AutoGenerateColumns = true;
                cmbOrderNo.SelectedItem = bill.Order;
                RefreshBillLines();
            }          
        }

        private void RefreshBillLines()
        {
            List<OrderItem> allItems = new List<OrderItem>();
            bill.Order.OrderItemGroups.ToList()
                .ForEach(group => group.OrderItems.ToList()
                                    .ForEach(item => allItems.Add(item)));

            var query = from i in allItems
                        join b in bill.BillLines on i equals b.OrderItem into outer
                        from b in outer.DefaultIfEmpty()
                        select new
                        {
                            Name = i.OrderItemGroup.Name + "-" + i.Name,
                            Quantity = i.OrderItemGroup.Quantity,
                            Amount = b == null ? 0 : b.Amount
                        };

            BindingSource binder = new BindingSource();
            binder.DataSource = query;
            grdBillLines.DataSource = binder;

            lblTotalAmountValue.Text = query.Select(p => p.Amount).Sum().ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges(SaveOptions.AcceptAllChangesAfterSave);
            MessageBox.Show("Saved Successfully");
            InitializeData();
        }

        private void cmbOrderNo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bill == null) return;

            bill.Order = (Order)cmbOrderNo.SelectedItem;

            if (bill.Order == null) //this can happen if the user types a value not present in the dropdown
            {
                lblCustomerNameValue.Text = "";
                grdBillLines.DataSource = null;
                lblTotalAmountValue.Text = "";
            }
            else
            {
                lblCustomerNameValue.Text = bill.Order.Customer.Name;
                RefreshBillLines();
            }
        }
    }
}