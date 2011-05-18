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
            grdReceipts.DataSource = context.Receipts
                                        .Select(p => 
                                            new { Id = p.Id, 
                                                  Customer = p.Bill.Order.Customer.Name, 
                                                  Amount = p.Amount 
                                            });
        }

        void loadAllCustomers()
        {
            cmbBills.DataSource = context.Bills; 
            cmbBills.DisplayMember = "Name";
        }

        void loadOutstandingCustomers()
        {
            //only those bills, where total receipt amount is lesser than total bill amount
            cmbBills.DataSource = context.Bills.Where(b =>
                                                b.BillLines.Select(bl => bl.Amount).Sum()
                                                    > b.Receipts.Select(r => r.Amount).Sum());
                                                                                
            cmbBills.DisplayMember = "Name";
        }


        void ReceiptScreen_Resize(object sender, EventArgs e)
        {
            receiptPanel.Width = this.Width;
            tblForm.Width = receiptPanel.Width;
            grdReceipts.Width = receiptPanel.Width * 8 / 10;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            receipt = new Receipt();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void bindReceiptToUI(Receipt r)
        {
        
        }

        private void grdReceipts_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
