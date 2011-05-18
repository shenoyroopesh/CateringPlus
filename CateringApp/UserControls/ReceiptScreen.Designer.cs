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
            this.grdReceipts = new System.Windows.Forms.DataGridView();
            this.tblForm = new System.Windows.Forms.TableLayoutPanel();
            this.lblBill = new System.Windows.Forms.Label();
            this.cmbBills = new System.Windows.Forms.ComboBox();
            this.lblAllReceipts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblReceiptNo = new System.Windows.Forms.Label();
            this.lblReceiptNoValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.receiptPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceipts)).BeginInit();
            this.tblForm.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // receiptPanel
            // 
            this.receiptPanel.Controls.Add(this.tblForm);
            this.receiptPanel.Controls.Add(this.flowLayoutPanel1);
            this.receiptPanel.Controls.Add(this.lblAllReceipts);
            this.receiptPanel.Controls.Add(this.grdReceipts);
            this.receiptPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.receiptPanel.Location = new System.Drawing.Point(18, 18);
            this.receiptPanel.Name = "receiptPanel";
            this.receiptPanel.Size = new System.Drawing.Size(623, 513);
            this.receiptPanel.TabIndex = 1;
            // 
            // grdReceipts
            // 
            this.grdReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReceipts.Location = new System.Drawing.Point(3, 168);
            this.grdReceipts.Name = "grdReceipts";
            this.grdReceipts.Size = new System.Drawing.Size(240, 150);
            this.grdReceipts.TabIndex = 1;
            this.grdReceipts.SelectionChanged += new System.EventHandler(this.grdReceipts_SelectionChanged);
            // 
            // tblForm
            // 
            this.tblForm.ColumnCount = 2;
            this.tblForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblForm.Controls.Add(this.lblReceiptNoValue, 1, 0);
            this.tblForm.Controls.Add(this.lblCustomerName, 1, 2);
            this.tblForm.Controls.Add(this.textBox1, 1, 3);
            this.tblForm.Controls.Add(this.label1, 0, 3);
            this.tblForm.Controls.Add(this.lblBill, 0, 1);
            this.tblForm.Controls.Add(this.lblCustomer, 0, 2);
            this.tblForm.Controls.Add(this.cmbBills, 1, 1);
            this.tblForm.Controls.Add(this.lblReceiptNo, 0, 0);
            this.tblForm.Location = new System.Drawing.Point(3, 3);
            this.tblForm.Name = "tblForm";
            this.tblForm.RowCount = 4;
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblForm.Size = new System.Drawing.Size(240, 108);
            this.tblForm.TabIndex = 2;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(3, 27);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(37, 13);
            this.lblBill.TabIndex = 0;
            this.lblBill.Text = "Bill No";
            // 
            // cmbBills
            // 
            this.cmbBills.FormattingEnabled = true;
            this.cmbBills.Location = new System.Drawing.Point(123, 30);
            this.cmbBills.Name = "cmbBills";
            this.cmbBills.Size = new System.Drawing.Size(114, 21);
            this.cmbBills.TabIndex = 2;
            // 
            // lblAllReceipts
            // 
            this.lblAllReceipts.AutoSize = true;
            this.lblAllReceipts.Location = new System.Drawing.Point(3, 152);
            this.lblAllReceipts.Name = "lblAllReceipts";
            this.lblAllReceipts.Size = new System.Drawing.Size(63, 13);
            this.lblAllReceipts.TabIndex = 3;
            this.lblAllReceipts.Text = "All Receipts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(3, 54);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(82, 13);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer Name";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(123, 54);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerName.TabIndex = 6;
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
            // lblReceiptNoValue
            // 
            this.lblReceiptNoValue.AutoSize = true;
            this.lblReceiptNoValue.Location = new System.Drawing.Point(123, 0);
            this.lblReceiptNoValue.Name = "lblReceiptNoValue";
            this.lblReceiptNoValue.Size = new System.Drawing.Size(0, 13);
            this.lblReceiptNoValue.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 117);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 32);
            this.flowLayoutPanel1.TabIndex = 4;
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
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(84, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdReceipts)).EndInit();
            this.tblForm.ResumeLayout(false);
            this.tblForm.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel receiptPanel;
        private System.Windows.Forms.DataGridView grdReceipts;
        private System.Windows.Forms.TableLayoutPanel tblForm;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.ComboBox cmbBills;
        private System.Windows.Forms.Label lblAllReceipts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblReceiptNo;
        private System.Windows.Forms.Label lblReceiptNoValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
    }
}
