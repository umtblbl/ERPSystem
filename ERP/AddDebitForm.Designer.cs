namespace ERP
{
    partial class AddDebitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDebitForm));
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.gridEmployees = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddDebit = new DevExpress.XtraEditors.SimpleButton();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProducts
            // 
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Location = new System.Drawing.Point(23, 37);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.RowTemplate.Height = 28;
            this.gridProducts.Size = new System.Drawing.Size(1000, 240);
            this.gridProducts.TabIndex = 0;
            this.gridProducts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridProducts_CellMouseClick);
            // 
            // gridEmployees
            // 
            this.gridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployees.Location = new System.Drawing.Point(23, 321);
            this.gridEmployees.Name = "gridEmployees";
            this.gridEmployees.RowTemplate.Height = 28;
            this.gridEmployees.Size = new System.Drawing.Size(1000, 240);
            this.gridEmployees.TabIndex = 1;
            this.gridEmployees.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridEmployees_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selected Product ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 608);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selected Employee ID:";
            // 
            // btnAddDebit
            // 
            this.btnAddDebit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDebit.ImageOptions.Image")));
            this.btnAddDebit.Location = new System.Drawing.Point(23, 658);
            this.btnAddDebit.Name = "btnAddDebit";
            this.btnAddDebit.Size = new System.Drawing.Size(138, 46);
            this.btnAddDebit.TabIndex = 6;
            this.btnAddDebit.Text = "Add Debit";
            this.btnAddDebit.Click += new System.EventHandler(this.btnAddDebit_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProduct.Location = new System.Drawing.Point(235, 572);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(0, 25);
            this.lblProduct.TabIndex = 7;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmployee.Location = new System.Drawing.Point(235, 608);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(0, 25);
            this.lblEmployee.TabIndex = 8;
            // 
            // AddDebitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 720);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.btnAddDebit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridEmployees);
            this.Controls.Add(this.gridProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDebitForm";
            this.Text = "AddDebitForm";
            this.Load += new System.EventHandler(this.AddDebitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.DataGridView gridEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnAddDebit;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblEmployee;
    }
}