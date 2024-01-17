namespace Ecommerce_App
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mngProducts = new System.Windows.Forms.LinkLabel();
            this.mngOrders = new System.Windows.Forms.LinkLabel();
            this.mngCategory = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.mngProducts);
            this.panel1.Controls.Add(this.mngOrders);
            this.panel1.Controls.Add(this.mngCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(829, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 601);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mngProducts
            // 
            this.mngProducts.AutoSize = true;
            this.mngProducts.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngProducts.LinkColor = System.Drawing.Color.White;
            this.mngProducts.Location = new System.Drawing.Point(16, 384);
            this.mngProducts.Name = "mngProducts";
            this.mngProducts.Size = new System.Drawing.Size(198, 22);
            this.mngProducts.TabIndex = 3;
            this.mngProducts.TabStop = true;
            this.mngProducts.Text = "MANAGE PRODUCTS";
            this.mngProducts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mngProducts_LinkClicked);
            // 
            // mngOrders
            // 
            this.mngOrders.AutoSize = true;
            this.mngOrders.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngOrders.LinkColor = System.Drawing.Color.White;
            this.mngOrders.Location = new System.Drawing.Point(17, 488);
            this.mngOrders.Name = "mngOrders";
            this.mngOrders.Size = new System.Drawing.Size(173, 22);
            this.mngOrders.TabIndex = 3;
            this.mngOrders.TabStop = true;
            this.mngOrders.Text = "MANAGE ORDERS";
            this.mngOrders.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mngOrders_LinkClicked);
            // 
            // mngCategory
            // 
            this.mngCategory.AutoSize = true;
            this.mngCategory.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngCategory.LinkColor = System.Drawing.Color.White;
            this.mngCategory.Location = new System.Drawing.Point(17, 436);
            this.mngCategory.Name = "mngCategory";
            this.mngCategory.Size = new System.Drawing.Size(194, 22);
            this.mngCategory.TabIndex = 3;
            this.mngCategory.TabStop = true;
            this.mngCategory.Text = "MANAGE CATEGORY";
            this.mngCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mngCategory_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 550);
            this.panel2.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(18, 537);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 22);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LOGOUT";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel mngOrders;
        private System.Windows.Forms.LinkLabel mngCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel mngProducts;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}