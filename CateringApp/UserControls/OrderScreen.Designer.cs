namespace CateringApp.UserControls
{
    partial class OrderScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.grdGroups = new System.Windows.Forms.DataGridView();
            this.grdItems = new System.Windows.Forms.DataGridView();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.orderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.itemsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.itemsInnerPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGroups = new System.Windows.Forms.Label();
            this.itemsInnerPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            this.orderPanel.SuspendLayout();
            this.itemsPanel.SuspendLayout();
            this.itemsInnerPanel1.SuspendLayout();
            this.itemsInnerPanel2.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblOrderID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOrderNo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblContactNo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblVenue, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtContactNo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbCustomerName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtVenue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblNote, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtNote, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(531, 138);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(268, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(0, 13);
            this.lblOrderID.TabIndex = 5;
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Location = new System.Drawing.Point(3, 0);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(50, 13);
            this.lblOrderNo.TabIndex = 0;
            this.lblOrderNo.Text = "Order No";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(3, 20);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(3, 40);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(61, 13);
            this.lblContactNo.TabIndex = 2;
            this.lblContactNo.Text = "Contact No";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(3, 60);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(38, 13);
            this.lblVenue.TabIndex = 3;
            this.lblVenue.Text = "Venue";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(268, 43);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(164, 20);
            this.txtContactNo.TabIndex = 2;
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(268, 23);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(164, 21);
            this.cmbCustomerName.TabIndex = 1;
            this.cmbCustomerName.SelectedValueChanged += new System.EventHandler(this.cmbCustomerName_SelectedValueChanged);
            this.cmbCustomerName.TextChanged += new System.EventHandler(this.cmbCustomerName_TextChanged);
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(268, 63);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(164, 20);
            this.txtVenue.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(268, 83);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 20);
            this.txtDate.TabIndex = 4;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(3, 100);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(30, 13);
            this.lblNote.TabIndex = 6;
            this.lblNote.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(268, 103);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.tableLayoutPanel1.SetRowSpan(this.txtNote, 2);
            this.txtNote.Size = new System.Drawing.Size(164, 34);
            this.txtNote.TabIndex = 5;
            // 
            // grdGroups
            // 
            this.grdGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGroups.Location = new System.Drawing.Point(3, 16);
            this.grdGroups.Name = "grdGroups";
            this.grdGroups.Size = new System.Drawing.Size(206, 106);
            this.grdGroups.TabIndex = 6;
            this.grdGroups.SelectionChanged += new System.EventHandler(this.grdGroups_SelectionChanged);
            // 
            // grdItems
            // 
            this.grdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItems.Location = new System.Drawing.Point(3, 16);
            this.grdItems.Name = "grdItems";
            this.grdItems.Size = new System.Drawing.Size(206, 106);
            this.grdItems.TabIndex = 7;
            // 
            // grdOrders
            // 
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Location = new System.Drawing.Point(3, 321);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.Size = new System.Drawing.Size(448, 150);
            this.grdOrders.TabIndex = 10;
            this.grdOrders.SelectionChanged += new System.EventHandler(this.grdOrders_SelectionChanged);
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
            // orderPanel
            // 
            this.orderPanel.Controls.Add(this.tableLayoutPanel1);
            this.orderPanel.Controls.Add(this.itemsPanel);
            this.orderPanel.Controls.Add(this.btnPanel);
            this.orderPanel.Controls.Add(this.grdOrders);
            this.orderPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.orderPanel.Location = new System.Drawing.Point(26, 17);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(547, 603);
            this.orderPanel.TabIndex = 5;
            // 
            // itemsPanel
            // 
            this.itemsPanel.Controls.Add(this.itemsInnerPanel1);
            this.itemsPanel.Controls.Add(this.itemsInnerPanel2);
            this.itemsPanel.Location = new System.Drawing.Point(3, 147);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(531, 132);
            this.itemsPanel.TabIndex = 5;
            // 
            // itemsInnerPanel1
            // 
            this.itemsInnerPanel1.Controls.Add(this.lblGroups);
            this.itemsInnerPanel1.Controls.Add(this.grdGroups);
            this.itemsInnerPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.itemsInnerPanel1.Location = new System.Drawing.Point(3, 3);
            this.itemsInnerPanel1.Name = "itemsInnerPanel1";
            this.itemsInnerPanel1.Size = new System.Drawing.Size(216, 139);
            this.itemsInnerPanel1.TabIndex = 9;
            // 
            // lblGroups
            // 
            this.lblGroups.AutoSize = true;
            this.lblGroups.Location = new System.Drawing.Point(3, 0);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(41, 13);
            this.lblGroups.TabIndex = 7;
            this.lblGroups.Text = "Groups";
            // 
            // itemsInnerPanel2
            // 
            this.itemsInnerPanel2.Controls.Add(this.lblItems);
            this.itemsInnerPanel2.Controls.Add(this.grdItems);
            this.itemsInnerPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.itemsInnerPanel2.Location = new System.Drawing.Point(225, 3);
            this.itemsInnerPanel2.Name = "itemsInnerPanel2";
            this.itemsInnerPanel2.Size = new System.Drawing.Size(226, 139);
            this.itemsInnerPanel2.TabIndex = 8;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(3, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(32, 13);
            this.lblItems.TabIndex = 8;
            this.lblItems.Text = "Items";
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.btnNew);
            this.btnPanel.Controls.Add(this.btnSave);
            this.btnPanel.Location = new System.Drawing.Point(3, 285);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(531, 30);
            this.btnPanel.TabIndex = 6;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(87, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // OrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.orderPanel);
            this.Name = "OrderScreen";
            this.Size = new System.Drawing.Size(624, 611);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            this.orderPanel.ResumeLayout(false);
            this.itemsPanel.ResumeLayout(false);
            this.itemsInnerPanel1.ResumeLayout(false);
            this.itemsInnerPanel1.PerformLayout();
            this.itemsInnerPanel2.ResumeLayout(false);
            this.itemsInnerPanel2.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.DataGridView grdGroups;
        private System.Windows.Forms.DataGridView grdItems;
        private System.Windows.Forms.DataGridView grdOrders;
        protected internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel orderPanel;
        private System.Windows.Forms.FlowLayoutPanel itemsPanel;
        private System.Windows.Forms.Panel btnPanel;
        protected internal System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.FlowLayoutPanel itemsInnerPanel1;
        private System.Windows.Forms.FlowLayoutPanel itemsInnerPanel2;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.Label lblItems;
    }
}
