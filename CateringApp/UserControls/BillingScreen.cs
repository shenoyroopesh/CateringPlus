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
                DataGridView tempGrid = d;
                this.BackColorChanged += new EventHandler((object sender, EventArgs e)
                    => { tempGrid.BackgroundColor = this.BackColor; });
                d.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            InitializeData();

            this.ParentChanged += new EventHandler(BillingScreen_ParentChanged);
        }

        void BillingScreen_ParentChanged(object sender, EventArgs e)
        {
            if (this.ParentForm == null) return;
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
        }

        private void loadUnbilledOrders() { cmbOrderNo.DataSource = context.Orders.Where(p => p.Bills.Count == 0); cmbOrderNo.DisplayMember = "Id"; }

        private void loadAllOrders() { cmbOrderNo.DataSource = context.Orders; cmbOrderNo.DisplayMember = "Id"; }


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
            //lose the previous changes
            context = new LocalDBEntities();
            bill = new Bill();            
            bill.Date = DateTime.Now.Date;
            context.Bills.AddObject(bill);
            bindBillToUI(bill);
            cmbOrderNo.Text = "";
            loadUnbilledOrders();
        }

        private void bindBillToUI(Bill bill)
        {
            lblBillNoValue.Text = bill.Id == 0 ? "[New]" : bill.Id.ToString();            
            if (bill.Order != null)
            {
                grdBillLines.AutoGenerateColumns = true;
                cmbOrderNo.Text = bill.Order.Id.ToString();
                cmbOrderNo.DisplayMember = "Id";
                RefreshBillLines();
            }
            cmbOrderNo.Enabled = (bill.Id == 0);
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
                            BillLineId = b == null? "" : b.Id.ToString(),
                            ItemId = i.Id.ToString(),
                            Name = i.OrderItemGroup.Name + "-" + i.Name,
                            Quantity = i.OrderItemGroup.Quantity,
                            Amount = b == null ? 0 : b.Amount
                        };

            BindingSource binder = new BindingSource();
            binder.DataSource = query;
            grdBillLines.DataSource = binder;

            if (grdBillLines.Columns["BillLineId"] != null) grdBillLines.Columns["BillLineId"].Visible = false;
            if (grdBillLines.Columns["ItemId"] != null) grdBillLines.Columns["ItemId"].Visible = false;
            if (grdBillLines.Columns["Amount"] != null) grdBillLines.Columns["Amount"].Visible = false;

            //since original Amount column cannot be modified, add another column that can be
            if (grdBillLines.Columns["AmountShown"] == null && grdBillLines.Columns["Amount"] != null)
            {
                grdBillLines.Columns.Add("AmountShown", "Amount");
            }

            foreach (DataGridViewRow row in grdBillLines.Rows) 
            { 
                row.Cells["AmountShown"].Value = row.Cells["Amount"].Value; 
            }
        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            //put the line level info into the bill lines
            foreach (DataGridViewRow row in grdBillLines.Rows)
            {
                double amount;
                //new rows
                if (row.Cells["BillLineId"].Value == null || 
                    row.Cells["BillLineId"].Value.ToString() == "" || 
                    row.Cells["BillLineId"].Value.ToString() == "0")
                {
                    BillLine line = new BillLine();
                    if (!Double.TryParse(row.Cells["AmountShown"].Value.ToString(), out amount)) amount = 0;
                    line.Amount = amount;
                    line.OrderItemId = Convert.ToInt32(row.Cells["ItemId"].Value);
                    bill.BillLines.Add(line);
                }
                else
                {
                    //existing bill lines
                    int billLineId = Convert.ToInt32(row.Cells["BillLineId"].Value);
                    BillLine line = bill.BillLines.Where(p => p.Id == billLineId).First();
                    if (!Double.TryParse(row.Cells["AmountShown"].Value.ToString(), out amount)) amount = 0;
                    line.Amount = amount;
                }
            }
            if(bill.Id == 0) context.Bills.AddObject(bill);
            context.SaveChanges(SaveOptions.AcceptAllChangesAfterSave);
            MessageBox.Show("Saved Successfully");
            InitializeData();
        }

        private void cmbOrderNo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bill == null || bill.Id != 0) return; //allowed only for new bills

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

        private void grdBills_SelectionChanged(object sender, EventArgs e)
        {
            //show the selection in the main form
            int billId = Convert.ToInt32(grdBills.CurrentRow.Cells["Id"].Value);
            loadAllOrders();
            bill = context.Bills.Where(p => p.Id == billId).First();
            bindBillToUI(bill);
        }

        private void grdBillLines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lblTotalAmountValue.Text = grdBillLines.Rows.Cast<DataGridViewRow>()
                                            .Select(row =>
                                                row.Cells["AmountShown"].Value ==  null ? 0 : Double.Parse(row.Cells["AmountShown"].Value.ToString()))
                                                    .Sum().ToString();
        }
    }
}