namespace ERP
{
    partial class RemoveDebitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveDebitForm));
            this.gridDebitList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDebitID = new System.Windows.Forms.Label();
            this.btnRemoveDebit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridDebitList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDebitList
            // 
            this.gridDebitList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDebitList.Location = new System.Drawing.Point(12, 12);
            this.gridDebitList.Name = "gridDebitList";
            this.gridDebitList.RowTemplate.Height = 28;
            this.gridDebitList.Size = new System.Drawing.Size(1000, 552);
            this.gridDebitList.TabIndex = 0;
            this.gridDebitList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridDebitList_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Debit ID:";
            // 
            // lblDebitID
            // 
            this.lblDebitID.AutoSize = true;
            this.lblDebitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDebitID.Location = new System.Drawing.Point(207, 587);
            this.lblDebitID.Name = "lblDebitID";
            this.lblDebitID.Size = new System.Drawing.Size(0, 25);
            this.lblDebitID.TabIndex = 2;
            // 
            // btnRemoveDebit
            // 
            this.btnRemoveDebit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveDebit.ImageOptions.Image")));
            this.btnRemoveDebit.Location = new System.Drawing.Point(12, 637);
            this.btnRemoveDebit.Name = "btnRemoveDebit";
            this.btnRemoveDebit.Size = new System.Drawing.Size(195, 48);
            this.btnRemoveDebit.TabIndex = 3;
            this.btnRemoveDebit.Text = "Remove Debit";
            this.btnRemoveDebit.Click += new System.EventHandler(this.btnRemoveDebit_Click);
            // 
            // RemoveDebitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 724);
            this.Controls.Add(this.btnRemoveDebit);
            this.Controls.Add(this.lblDebitID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridDebitList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveDebitForm";
            this.Text = "RemoveDebitForm";
            this.Load += new System.EventHandler(this.RemoveDebitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDebitList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDebitList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDebitID;
        private DevExpress.XtraEditors.SimpleButton btnRemoveDebit;
    }
}