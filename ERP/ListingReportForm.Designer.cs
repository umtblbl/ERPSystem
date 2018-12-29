namespace ERP
{
    partial class ListingReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListingReportForm));
            this.gridListing = new System.Windows.Forms.DataGridView();
            this.btnListingEvent = new DevExpress.XtraEditors.SimpleButton();
            this.btnListingProducts = new DevExpress.XtraEditors.SimpleButton();
            this.btnListingEvents = new DevExpress.XtraEditors.SimpleButton();
            this.btnListingDebits = new DevExpress.XtraEditors.SimpleButton();
            this.btnListingDiscardedProducts = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDiscartedProductsPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintDebits = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintProducts = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintEmployees = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintEvents = new DevExpress.XtraEditors.SimpleButton();
            this.pDocEvents = new System.Drawing.Printing.PrintDocument();
            this.pDialogEvents = new System.Windows.Forms.PrintPreviewDialog();
            this.pDocEmployees = new System.Drawing.Printing.PrintDocument();
            this.pDialogEmplooyes = new System.Windows.Forms.PrintPreviewDialog();
            this.pDocProducts = new System.Drawing.Printing.PrintDocument();
            this.pDialogProducts = new System.Windows.Forms.PrintPreviewDialog();
            this.pDocDebits = new System.Drawing.Printing.PrintDocument();
            this.pDialogDebits = new System.Windows.Forms.PrintPreviewDialog();
            this.pDocDiscarded = new System.Drawing.Printing.PrintDocument();
            this.pDialogDiscarded = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridListing)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridListing
            // 
            this.gridListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListing.Location = new System.Drawing.Point(11, 12);
            this.gridListing.Name = "gridListing";
            this.gridListing.RowTemplate.Height = 28;
            this.gridListing.Size = new System.Drawing.Size(1000, 436);
            this.gridListing.TabIndex = 0;
            // 
            // btnListingEvent
            // 
            this.btnListingEvent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListingEvent.ImageOptions.Image")));
            this.btnListingEvent.Location = new System.Drawing.Point(193, 44);
            this.btnListingEvent.Name = "btnListingEvent";
            this.btnListingEvent.Size = new System.Drawing.Size(195, 52);
            this.btnListingEvent.TabIndex = 1;
            this.btnListingEvent.Text = "Listing Employees";
            this.btnListingEvent.Click += new System.EventHandler(this.btnListingEvent_Click);
            // 
            // btnListingProducts
            // 
            this.btnListingProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListingProducts.ImageOptions.Image")));
            this.btnListingProducts.Location = new System.Drawing.Point(394, 44);
            this.btnListingProducts.Name = "btnListingProducts";
            this.btnListingProducts.Size = new System.Drawing.Size(201, 52);
            this.btnListingProducts.TabIndex = 2;
            this.btnListingProducts.Text = "Listing Products";
            this.btnListingProducts.Click += new System.EventHandler(this.btnListingProducts_Click);
            // 
            // btnListingEvents
            // 
            this.btnListingEvents.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListingEvents.ImageOptions.Image")));
            this.btnListingEvents.Location = new System.Drawing.Point(6, 44);
            this.btnListingEvents.Name = "btnListingEvents";
            this.btnListingEvents.Size = new System.Drawing.Size(181, 52);
            this.btnListingEvents.TabIndex = 3;
            this.btnListingEvents.Text = "Listing Events";
            this.btnListingEvents.Click += new System.EventHandler(this.btnListingEvents_Click_1);
            // 
            // btnListingDebits
            // 
            this.btnListingDebits.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListingDebits.ImageOptions.Image")));
            this.btnListingDebits.Location = new System.Drawing.Point(601, 44);
            this.btnListingDebits.Name = "btnListingDebits";
            this.btnListingDebits.Size = new System.Drawing.Size(180, 52);
            this.btnListingDebits.TabIndex = 4;
            this.btnListingDebits.Text = "Listing Debits";
            this.btnListingDebits.Click += new System.EventHandler(this.btnListingDebits_Click);
            // 
            // btnListingDiscardedProducts
            // 
            this.btnListingDiscardedProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListingDiscardedProducts.ImageOptions.Image")));
            this.btnListingDiscardedProducts.Location = new System.Drawing.Point(787, 44);
            this.btnListingDiscardedProducts.Name = "btnListingDiscardedProducts";
            this.btnListingDiscardedProducts.Size = new System.Drawing.Size(216, 52);
            this.btnListingDiscardedProducts.TabIndex = 5;
            this.btnListingDiscardedProducts.Text = "Discarded Products";
            this.btnListingDiscardedProducts.Click += new System.EventHandler(this.btnListingDiscardedProducts_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDiscartedProductsPrint);
            this.groupBox1.Controls.Add(this.btnPrintDebits);
            this.groupBox1.Controls.Add(this.btnListingDiscardedProducts);
            this.groupBox1.Controls.Add(this.btnPrintProducts);
            this.groupBox1.Controls.Add(this.btnListingDebits);
            this.groupBox1.Controls.Add(this.btnPrintEmployees);
            this.groupBox1.Controls.Add(this.btnListingEvents);
            this.groupBox1.Controls.Add(this.btnPrintEvents);
            this.groupBox1.Controls.Add(this.btnListingProducts);
            this.groupBox1.Controls.Add(this.btnListingEvent);
            this.groupBox1.Location = new System.Drawing.Point(12, 472);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 167);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Operations";
            // 
            // btnDiscartedProductsPrint
            // 
            this.btnDiscartedProductsPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscartedProductsPrint.ImageOptions.Image")));
            this.btnDiscartedProductsPrint.Location = new System.Drawing.Point(787, 102);
            this.btnDiscartedProductsPrint.Name = "btnDiscartedProductsPrint";
            this.btnDiscartedProductsPrint.Size = new System.Drawing.Size(103, 34);
            this.btnDiscartedProductsPrint.TabIndex = 11;
            this.btnDiscartedProductsPrint.Text = "Print";
            this.btnDiscartedProductsPrint.Click += new System.EventHandler(this.btnDiscartedProductsPrint_Click);
            // 
            // btnPrintDebits
            // 
            this.btnPrintDebits.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDebits.ImageOptions.Image")));
            this.btnPrintDebits.Location = new System.Drawing.Point(601, 102);
            this.btnPrintDebits.Name = "btnPrintDebits";
            this.btnPrintDebits.Size = new System.Drawing.Size(103, 34);
            this.btnPrintDebits.TabIndex = 10;
            this.btnPrintDebits.Text = "Print";
            this.btnPrintDebits.Click += new System.EventHandler(this.btnPrintDebits_Click);
            // 
            // btnPrintProducts
            // 
            this.btnPrintProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintProducts.ImageOptions.Image")));
            this.btnPrintProducts.Location = new System.Drawing.Point(394, 102);
            this.btnPrintProducts.Name = "btnPrintProducts";
            this.btnPrintProducts.Size = new System.Drawing.Size(105, 34);
            this.btnPrintProducts.TabIndex = 9;
            this.btnPrintProducts.Text = "Print";
            this.btnPrintProducts.Click += new System.EventHandler(this.btnPrintProducts_Click);
            // 
            // btnPrintEmployees
            // 
            this.btnPrintEmployees.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintEmployees.ImageOptions.Image")));
            this.btnPrintEmployees.Location = new System.Drawing.Point(193, 102);
            this.btnPrintEmployees.Name = "btnPrintEmployees";
            this.btnPrintEmployees.Size = new System.Drawing.Size(101, 34);
            this.btnPrintEmployees.TabIndex = 8;
            this.btnPrintEmployees.Text = "Print";
            this.btnPrintEmployees.Click += new System.EventHandler(this.btnPrintEmployees_Click);
            // 
            // btnPrintEvents
            // 
            this.btnPrintEvents.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintEvents.ImageOptions.Image")));
            this.btnPrintEvents.Location = new System.Drawing.Point(6, 102);
            this.btnPrintEvents.Name = "btnPrintEvents";
            this.btnPrintEvents.Size = new System.Drawing.Size(98, 34);
            this.btnPrintEvents.TabIndex = 7;
            this.btnPrintEvents.Text = "Print";
            this.btnPrintEvents.Click += new System.EventHandler(this.btnPrintEvents_Click);
            // 
            // pDocEvents
            // 
            this.pDocEvents.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDocEvents_PrintPage);
            // 
            // pDialogEvents
            // 
            this.pDialogEvents.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pDialogEvents.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pDialogEvents.ClientSize = new System.Drawing.Size(400, 300);
            this.pDialogEvents.Document = this.pDocEvents;
            this.pDialogEvents.Enabled = true;
            this.pDialogEvents.Icon = ((System.Drawing.Icon)(resources.GetObject("pDialogEvents.Icon")));
            this.pDialogEvents.Name = "pDialogEvents";
            this.pDialogEvents.Text = "Baskı önizleme";
            this.pDialogEvents.Visible = false;
            // 
            // pDocEmployees
            // 
            this.pDocEmployees.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDocEmployees_PrintPage);
            // 
            // pDialogEmplooyes
            // 
            this.pDialogEmplooyes.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pDialogEmplooyes.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pDialogEmplooyes.ClientSize = new System.Drawing.Size(400, 300);
            this.pDialogEmplooyes.Document = this.pDocEmployees;
            this.pDialogEmplooyes.Enabled = true;
            this.pDialogEmplooyes.Icon = ((System.Drawing.Icon)(resources.GetObject("pDialogEmplooyes.Icon")));
            this.pDialogEmplooyes.Name = "pDialogEmplooyes";
            this.pDialogEmplooyes.Text = "Baskı önizleme";
            this.pDialogEmplooyes.Visible = false;
            // 
            // pDocProducts
            // 
            this.pDocProducts.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDocProducts_PrintPage);
            // 
            // pDialogProducts
            // 
            this.pDialogProducts.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pDialogProducts.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pDialogProducts.ClientSize = new System.Drawing.Size(400, 300);
            this.pDialogProducts.Document = this.pDocProducts;
            this.pDialogProducts.Enabled = true;
            this.pDialogProducts.Icon = ((System.Drawing.Icon)(resources.GetObject("pDialogProducts.Icon")));
            this.pDialogProducts.Name = "pDialogProducts";
            this.pDialogProducts.Text = "Baskı önizleme";
            this.pDialogProducts.Visible = false;
            // 
            // pDocDebits
            // 
            this.pDocDebits.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDocDebits_PrintPage);
            // 
            // pDialogDebits
            // 
            this.pDialogDebits.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pDialogDebits.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pDialogDebits.ClientSize = new System.Drawing.Size(400, 300);
            this.pDialogDebits.Document = this.pDocDebits;
            this.pDialogDebits.Enabled = true;
            this.pDialogDebits.Icon = ((System.Drawing.Icon)(resources.GetObject("pDialogDebits.Icon")));
            this.pDialogDebits.Name = "printPreviewDialog1";
            this.pDialogDebits.Text = "Baskı önizleme";
            this.pDialogDebits.Visible = false;
            // 
            // pDocDiscarded
            // 
            this.pDocDiscarded.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDocDiscarded_PrintPage);
            // 
            // pDialogDiscarded
            // 
            this.pDialogDiscarded.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pDialogDiscarded.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pDialogDiscarded.ClientSize = new System.Drawing.Size(400, 300);
            this.pDialogDiscarded.Document = this.pDocDiscarded;
            this.pDialogDiscarded.Enabled = true;
            this.pDialogDiscarded.Icon = ((System.Drawing.Icon)(resources.GetObject("pDialogDiscarded.Icon")));
            this.pDialogDiscarded.Name = "pDialogDiscarded";
            this.pDialogDiscarded.Text = "Baskı önizleme";
            this.pDialogDiscarded.Visible = false;
            // 
            // ListingReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 756);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridListing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListingReportForm";
            this.Text = "ListingReportForm";
            this.Load += new System.EventHandler(this.ListingReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListing)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridListing;
        private DevExpress.XtraEditors.SimpleButton btnListingEvent;
        private DevExpress.XtraEditors.SimpleButton btnListingProducts;
        private DevExpress.XtraEditors.SimpleButton btnListingEvents;
        private DevExpress.XtraEditors.SimpleButton btnListingDebits;
        private DevExpress.XtraEditors.SimpleButton btnListingDiscardedProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Drawing.Printing.PrintDocument pDocEvents;
        private System.Windows.Forms.PrintPreviewDialog pDialogEvents;
        private DevExpress.XtraEditors.SimpleButton btnPrintEvents;
        private System.Drawing.Printing.PrintDocument pDocEmployees;
        private System.Windows.Forms.PrintPreviewDialog pDialogEmplooyes;
        private DevExpress.XtraEditors.SimpleButton btnPrintEmployees;
        private System.Drawing.Printing.PrintDocument pDocProducts;
        private System.Windows.Forms.PrintPreviewDialog pDialogProducts;
        private DevExpress.XtraEditors.SimpleButton btnPrintProducts;
        private System.Drawing.Printing.PrintDocument pDocDebits;
        private System.Windows.Forms.PrintPreviewDialog pDialogDebits;
        private DevExpress.XtraEditors.SimpleButton btnPrintDebits;
        private DevExpress.XtraEditors.SimpleButton btnDiscartedProductsPrint;
        private System.Drawing.Printing.PrintDocument pDocDiscarded;
        private System.Windows.Forms.PrintPreviewDialog pDialogDiscarded;
    }
}