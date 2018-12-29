namespace ERP
{
    partial class RemoveProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveProductForm));
            this.gridListingProduct = new System.Windows.Forms.DataGridView();
            this.btnRemoveProduct = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridListingProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gridListingProduct
            // 
            this.gridListingProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListingProduct.Location = new System.Drawing.Point(12, 12);
            this.gridListingProduct.Name = "gridListingProduct";
            this.gridListingProduct.RowTemplate.Height = 28;
            this.gridListingProduct.Size = new System.Drawing.Size(1000, 487);
            this.gridListingProduct.TabIndex = 0;
            this.gridListingProduct.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridListingProduct_CellMouseClick);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveProduct.ImageOptions.Image")));
            this.btnRemoveProduct.Location = new System.Drawing.Point(12, 567);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(222, 57);
            this.btnRemoveProduct.TabIndex = 1;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Product ID:";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductID.Location = new System.Drawing.Point(225, 525);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(0, 25);
            this.lblProductID.TabIndex = 3;
            // 
            // RemoveProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 661);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.gridListingProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveProductForm";
            this.Text = "RemoveProductForm";
            this.Load += new System.EventHandler(this.RemoveProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListingProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridListingProduct;
        private DevExpress.XtraEditors.SimpleButton btnRemoveProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductID;
    }
}