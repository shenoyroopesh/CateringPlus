namespace CateringApp.UserControls
{
    partial class BillingScreen
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
            this.mainContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.lblCustomerNameValue = new System.Windows.Forms.Label();
            this.lblBillNoValue = new System.Windows.Forms.Label();
            this.cmbOrderNo = new System.Windows.Forms.ComboBox();
            this.lblBillLines = new System.Windows.Forms.Label();
            this.grdBillLines = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBill = new System.Windows.Forms.Label();
            this.grdBills = new System.Windows.Forms.DataGridView();
            this.mainContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBillLines)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.btnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBills)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.tableLayoutPanel1);
            this.mainContainer.Controls.Add(this.lblBillLines);
            this.mainContainer.Controls.Add(this.grdBillLines);
            this.mainContainer.Controls.Add(this.tableLayoutPanel2);
            this.mainContainer.Controls.Add(this.btnPanel);
            this.mainContainer.Controls.Add(this.lblBill);
            this.mainContainer.Controls.Add(this.grdBills);
            this.mainContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainContainer.Location = new System.Drawing.Point(19, 17);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(560, 502);
            this.mainContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblOrderNo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBillNo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerNameValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBillNoValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbOrderNo, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 71);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Customer Name";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Location = new System.Drawing.Point(3, 25);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(50, 13);
            this.lblOrderNo.TabIndex = 7;
            this.lblOrderNo.Text = "Order No";
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Location = new System.Drawing.Point(3, 0);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(37, 13);
            this.lblBillNo.TabIndex = 6;
            this.lblBillNo.Text = "Bill No";
            // 
            // lblCustomerNameValue
            // 
            this.lblCustomerNameValue.AutoSize = true;
            this.lblCustomerNameValue.Location = new System.Drawing.Point(103, 50);
            this.lblCustomerNameValue.Name = "lblCustomerNameValue";
            this.lblCustomerNameValue.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerNameValue.TabIndex = 8;
            // 
            // lblBillNoValue
            // 
            this.lblBillNoValue.AutoSize = true;
            this.lblBillNoValue.Location = new System.Drawing.Point(103, 0);
            this.lblBillNoValue.Name = "lblBillNoValue";
            this.lblBillNoValue.Size = new System.Drawing.Size(0, 13);
            this.lblBillNoValue.TabIndex = 9;
            // 
            // cmbOrderNo
            // 
            this.cmbOrderNo.FormattingEnabled = true;
            this.cmbOrderNo.Location = new System.Drawing.Point(103, 28);
            this.cmbOrderNo.Name = "cmbOrderNo";
            this.cmbOrderNo.Size = new System.Drawing.Size(94, 21);
            this.cmbOrderNo.TabIndex = 10;
            this.cmbOrderNo.SelectedValueChanged += new System.EventHandler(this.cmbOrderNo_SelectedValueChanged);
            // 
            // lblBillLines
            // 
            this.lblBillLines.AutoSize = true;
            this.lblBillLines.Location = new System.Drawing.Point(3, 77);
            this.lblBillLines.Name = "lblBillLines";
            this.lblBillLines.Size = new System.Drawing.Size(48, 13);
            this.lblBillLines.TabIndex = 5;
            this.lblBillLines.Text = "Bill Lines";
            // 
            // grdBillLines
            // 
            this.grdBillLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBillLines.Location = new System.Drawing.Point(3, 93);
            this.grdBillLines.Name = "grdBillLines";
            this.grdBillLines.Size = new System.Drawing.Size(240, 150);
            this.grdBillLines.TabIndex = 4;
            this.grdBillLines.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBillLines_CellValueChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblTotalAmountValue, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalAmount, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 249);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 19);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Location = new System.Drawing.Point(103, 0);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(0, 13);
            this.lblTotalAmountValue.TabIndex = 11;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(3, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(70, 13);
            this.lblTotalAmount.TabIndex = 10;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.btnPrint);
            this.btnPanel.Controls.Add(this.btnNew);
            this.btnPanel.Controls.Add(this.btnSave);
            this.btnPanel.Location = new System.Drawing.Point(3, 274);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(249, 30);
            this.btnPanel.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(87, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(168, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(3, 307);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(39, 13);
            this.lblBill.TabIndex = 2;
            this.lblBill.Text = "All Bills";
            // 
            // grdBills
            // 
            this.grdBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBills.Location = new System.Drawing.Point(3, 323);
            this.grdBills.Name = "grdBills";
            this.grdBills.Size = new System.Drawing.Size(240, 150);
            this.grdBills.TabIndex = 3;
            this.grdBills.SelectionChanged += new System.EventHandler(this.grdBills_SelectionChanged);
            // 
            // BillingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "BillingScreen";
            this.Size = new System.Drawing.Size(611, 542);
            this.Resize += new System.EventHandler(this.BillingScreen_Resize);
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBillLines)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainContainer;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.DataGridView grdBills;
        private System.Windows.Forms.DataGridView grdBillLines;
        private System.Windows.Forms.Label lblBillLines;
        private System.Windows.Forms.Panel btnPanel;
        protected internal System.Windows.Forms.Button btnNew;
        protected internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.Label lblCustomerNameValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBillNoValue;
        private System.Windows.Forms.ComboBox cmbOrderNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalAmountValue;
        protected internal System.Windows.Forms.Button btnPrint;
    }
}
