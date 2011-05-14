namespace CateringApp
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainFormContainer = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormContainer)).BeginInit();
            this.mainFormContainer.Panel2.SuspendLayout();
            this.mainFormContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormContainer
            // 
            this.mainFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormContainer.Location = new System.Drawing.Point(0, 0);
            this.mainFormContainer.Name = "mainFormContainer";
            // 
            // mainFormContainer.Panel2
            // 
            this.mainFormContainer.Panel2.Controls.Add(this.menuStrip1);
            this.mainFormContainer.Size = new System.Drawing.Size(784, 562);
            this.mainFormContainer.SplitterDistance = 261;
            this.mainFormContainer.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(519, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.mainFormContainer);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CateringPlus";
            this.mainFormContainer.Panel2.ResumeLayout(false);
            this.mainFormContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormContainer)).EndInit();
            this.mainFormContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainFormContainer;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

