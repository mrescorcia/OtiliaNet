
namespace OtiliaNet.OtiliaNet_GUI
{
    partial class Productos
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
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.LNameProduct = new System.Windows.Forms.Label();
            this.LDescProduct = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtDescProduct = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProducts
            // 
            this.dtgProducts.AllowUserToAddRows = false;
            this.dtgProducts.AllowUserToDeleteRows = false;
            this.dtgProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducts.Location = new System.Drawing.Point(12, 143);
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.ReadOnly = true;
            this.dtgProducts.RowHeadersVisible = false;
            this.dtgProducts.Size = new System.Drawing.Size(776, 295);
            this.dtgProducts.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(12, 114);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // LNameProduct
            // 
            this.LNameProduct.AutoSize = true;
            this.LNameProduct.Location = new System.Drawing.Point(12, 9);
            this.LNameProduct.Name = "LNameProduct";
            this.LNameProduct.Size = new System.Drawing.Size(78, 13);
            this.LNameProduct.TabIndex = 2;
            this.LNameProduct.Text = "Name Product:";
            // 
            // LDescProduct
            // 
            this.LDescProduct.AutoSize = true;
            this.LDescProduct.Location = new System.Drawing.Point(12, 39);
            this.LDescProduct.Name = "LDescProduct";
            this.LDescProduct.Size = new System.Drawing.Size(75, 13);
            this.LDescProduct.TabIndex = 3;
            this.LDescProduct.Text = "Desc Product:";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(96, 6);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(100, 20);
            this.txtNameProduct.TabIndex = 4;
            // 
            // txtDescProduct
            // 
            this.txtDescProduct.Location = new System.Drawing.Point(96, 39);
            this.txtDescProduct.Name = "txtDescProduct";
            this.txtDescProduct.Size = new System.Drawing.Size(100, 20);
            this.txtDescProduct.TabIndex = 5;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDescProduct);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.LDescProduct);
            this.Controls.Add(this.LNameProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dtgProducts);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label LNameProduct;
        private System.Windows.Forms.Label LDescProduct;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtDescProduct;
    }
}