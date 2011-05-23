namespace CateringApp.UserControls
{
    partial class ReceiptScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.receiptPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tblForm = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiptNoValue = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbBills = new System.Windows.Forms.ComboBox();
            this.lblReceiptNo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblBillOutstanding = new System.Windows.Forms.Label();
            this.lblOutstandingValue = new System.Windows.Forms.Label();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAllReceipts = new System.Windows.Forms.Label();
            this.grdReceipts = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.receiptPanel.SuspendLayout();
            this.tblForm.SuspendLayout();
            this.btnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceipts)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptPanel
            // 
            this.receiptPanel.Controls.Add(this.tblForm);
            this.receiptPanel.Controls.Add(this.btnPanel);
            this.receiptPanel.Controls.Add(this.lblAllReceipts);
            this.receiptPanel.Controls.Add(this.grdReceipts);
            this.receiptPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.receiptPanel.Location = new System.Drawing.Point(18, 18);
            this.receiptPanel.Name = "receiptPanel";
            this.receiptPanel.Size = new System.Drawing.Size(623, 513);
            this.receiptPanel.TabIndex = 1;
            // 
            // tblForm
            // 
            this.tblForm.ColumnCount = 2;
            this.tblForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblForm.Controls.Add(this.lblReceiptNoValue, 1, 0);
            this.tblForm.Controls.Add(this.lblCustomerName, 1, 2);
            this.tblForm.Controls.Add(this.lblBill, 0, 1);
            this.tblForm.Controls.Add(this.lblCustomer, 0, 2);
            this.tblForm.Controls.Add(this.cmbBills, 1, 1);
            this.tblForm.Controls.Add(this.lblReceiptNo, 0, 0);
            this.tblForm.Controls.Add(this.lblDate, 0, 3);
            this.tblForm.Controls.Add(this.dtDate, 1, 3);
            this.tblForm.Controls.Add(this.label1, 0, 5);
            this.tblForm.Controls.Add(this.txtAmount, 1, 5);
            this.tblForm.Controls.Add(this.lblBillOutstanding, 0, 4);
            this.tblForm.Controls.Add(this.lblOutstandingValue, 1, 4);
            this.tblForm.Location = new System.Drawing.Point(3, 3);
            this.tblForm.Name = "tblForm";
            this.tblForm.RowCount = 6;
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblForm.Size = new System.Drawing.Size(240, 154);
            this.tblForm.TabIndex = 2;
            // 
            // lblReceiptNoValue
            // 
            this.lblReceiptNoValue.AutoSize = true;
            this.lblReceiptNoValue.Location = new System.Drawing.Point(123, 0);
            this.lblReceiptNoValue.Name = "lblReceiptNoValue";
            this.lblReceiptNoValue.Size = new System.Drawing.Size(0, 13);
            this.lblReceiptNoValue.TabIndex = 8;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(123, 50);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerName.TabIndex = 6;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(3, 25);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(37, 13);
            this.lblBill.TabIndex = 0;
            this.lblBill.Text = "Bill No";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(3, 50);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(82, 13);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer Name";
            // 
            // cmbBills
            // 
            this.cmbBills.FormattingEnabled = true;
            this.cmbBills.Location = new System.Drawing.Point(123, 28);
            this.cmbBills.Name = "cmbBills";
            this.cmbBills.Size = new System.Drawing.Size(114, 21);
            this.cmbBills.TabIndex = 2;
            this.cmbBills.SelectedIndexChanged += new System.EventHandler(this.cmbBills_SelectedIndexChanged);
            // 
            // lblReceiptNo
            // 
            this.lblReceiptNo.AutoSize = true;
            this.lblReceiptNo.Location = new System.Drawing.Point(3, 0);
            this.lblReceiptNo.Name = "lblReceiptNo";
            this.lblReceiptNo.Size = new System.Drawing.Size(61, 13);
            this.lblReceiptNo.TabIndex = 7;
            this.lblReceiptNo.Text = "Receipt No";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 75);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // dtDate
            // 
            this.dtDate.Checked = false;
            this.dtDate.Location = new System.Drawing.Point(123, 78);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(114, 20);
            this.dtDate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(123, 128);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(114, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // lblBillOutstanding
            // 
            this.lblBillOutstanding.AutoSize = true;
            this.lblBillOutstanding.Location = new System.Drawing.Point(3, 100);
            this.lblBillOutstanding.Name = "lblBillOutstanding";
            this.lblBillOutstanding.Size = new System.Drawing.Size(103, 13);
            this.lblBillOutstanding.TabIndex = 11;
            this.lblBillOutstanding.Text = "Outstanding Amount";
            // 
            // lblOutstandingValue
            // 
            this.lblOutstandingValue.AutoSize = true;
            this.lblOutstandingValue.Location = new System.Drawing.Point(123, 100);
            this.lblOutstandingValue.Name = "lblOutstandingValue";
            this.lblOutstandingValue.Size = new System.Drawing.Size(0, 13);
            this.lblOutstandingValue.TabIndex = 12;
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.btnPrint);
            this.btnPanel.Controls.Add(this.btnNew);
            this.btnPanel.Controls.Add(this.btnSave);
            this.btnPanel.Location = new System.Drawing.Point(3, 163);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(250, 28);
            this.btnPanel.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(162, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAllReceipts
            // 
            this.lblAllReceipts.AutoSize = true;
            this.lblAllReceipts.Location = new System.Drawing.Point(3, 194);
            this.lblAllReceipts.Name = "lblAllReceipts";
            this.lblAllReceipts.Size = new System.Drawing.Size(63, 13);
            this.lblAllReceipts.TabIndex = 3;
            this.lblAllReceipts.Text = "All Receipts";
            // 
            // grdReceipts
            // 
            this.grdReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReceipts.Location = new System.Drawing.Point(3, 210);
            this.grdReceipts.Name = "grdReceipts";
            this.grdReceipts.Size = new System.Drawing.Size(240, 150);
            this.grdReceipts.TabIndex = 1;
            this.grdReceipts.SelectionChanged += new System.EventHandler(this.grdReceipts_SelectionChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(84, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ReceiptScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.receiptPanel);
            this.Name = "ReceiptScreen";
            this.Size = new System.Drawing.Size(667, 555);
            this.receiptPanel.ResumeLayout(false);
            this.receiptPanel.PerformLayout();
            this.tblForm.ResumeLayout(false);
            this.tblForm.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReceipts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel receiptPanel;
        private System.Windows.Forms.DataGridView grdReceipts;
        private System.Windows.Forms.TableLayoutPanel tblForm;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.ComboBox cmbBills;
        private System.Windows.Forms.Label lblAllReceipts;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblReceiptNo;
        private System.Windows.Forms.Label lblReceiptNoValue;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Label lblBillOutstanding;
        private System.Windows.Forms.Label lblOutstandingValue;
        private System.Windows.Forms.Button btnPrint;
    }
}
