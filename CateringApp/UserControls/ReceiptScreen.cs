using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CateringApp.UserControls
{
    public partial class ReceiptScreen : UserControl
    {
        LocalDBEntities context;
        Receipt receipt;

        public ReceiptScreen()
        {
            InitializeComponent();
            Resize += new EventHandler(ReceiptScreen_Resize);
            grdReceipts.AutoGenerateColumns = true;
            grdReceipts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grdReceipts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridView tempGrid = grdReceipts;
            this.BackColorChanged += new EventHandler((object sender, EventArgs e)
                => { tempGrid.BackgroundColor = this.BackColor; });
            grdReceipts.BorderStyle = System.Windows.Forms.BorderStyle.None;

            InitializeData();
        }

        void InitializeData()
        {
            context = new LocalDBEntities();
            grdReceipts.DataSource = context.Receipts.OrderByDescending(r => r.Id)
                                        .Select(p => 
                                            new { Id = p.Id, 
                                                  Customer = p.Bill.Order.Customer.Name, 
                                                  Amount = p.Amount 
                                            });
        }

        void loadAllBills()
        {
            cmbBills.DataSource = context.Bills; 
            cmbBills.DisplayMember = "Id";
        }

        void loadOutstandingBills()
        {
            //only those bills, where total receipt amount is lesser than total bill amount
            cmbBills.DataSource = context.Bills.Where(b =>
                                                b.BillLines.Select(bl => bl.Amount).Sum()
                                                    > (b.Receipts.Count == 0? 0: b.Receipts.Select(r => r.Amount).Sum()));
                                                                                
            cmbBills.DisplayMember = "Id";
        }


        void ReceiptScreen_Resize(object sender, EventArgs e)
        {
            receiptPanel.Width = this.Width;
            tblForm.Width = receiptPanel.Width;
            grdReceipts.Width = receiptPanel.Width * 8 / 10;
            btnPanel.Width = receiptPanel.Width * 8 / 10;
            btnPanel.Height = btnSave.Height * 12 / 10;
            btnSave.Left = btnSave.Parent.Width * 2 / 10;
            btnPrint.Left = btnPrint.Parent.Width * 4 / 10;
            btnNew.Left = btnNew.Parent.Width * 6 / 10;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            receipt = new Receipt();
            loadOutstandingBills();
            bindReceiptToUI(receipt);

            cmbBills.Text = "";
            lblCustomerName.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            receipt.Bill = (Bill)cmbBills.SelectedItem;
            double amount;
            bool result = Double.TryParse(txtAmount.Text, out amount);
            receipt.Amount = result ? amount : 0;
            receipt.Date = dtDate.Value.Date;
            context.SaveChanges();

            InitializeData();
        }

        private void bindReceiptToUI(Receipt r)
        { 
            lblReceiptNoValue.Text = r.Id == 0 ? "[New]" : r.Id.ToString();
            txtAmount.Text = r.Amount.ToString();
            dtDate.Value = r.Date==null? DateTime.Today: (DateTime)r.Date;
            cmbBills.SelectedItem = r.Bill;
        }

        private void grdReceipts_SelectionChanged(object sender, EventArgs e)
        {
            if (grdReceipts.SelectedCells.Count == 0) return;

            int rId = Convert.ToInt32(grdReceipts.SelectedCells[0].OwningRow.Cells["Id"].Value);
            receipt = context.Receipts.Where(p => p.Id == rId).First();
            loadAllBills();
            bindReceiptToUI(receipt);
        }

        private void cmbBills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBills.SelectedItem == null)
            {
                lblCustomerName.Text = ""; lblOutstandingValue.Text = ""; return;
            }

            Bill b = (Bill)cmbBills.SelectedItem;

            lblCustomerName.Text = b.Order.Customer.Name;
            Double outstanding = b.BillLines.Select(bl => bl.Amount).Sum() - 
                                            (b.Receipts.Count == 0? 0: b.Receipts.Select(r => r.Amount).Sum());
            lblOutstandingValue.Text = outstanding.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}