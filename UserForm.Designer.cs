namespace Ecommerce_App
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewProductsLink = new System.Windows.Forms.LinkLabel();
            this.checkoutLink = new System.Windows.Forms.LinkLabel();
            this.myOrdersLink = new System.Windows.Forms.LinkLabel();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.logoutLink);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.viewProductsLink);
            this.panel1.Controls.Add(this.checkoutLink);
            this.panel1.Controls.Add(this.myOrdersLink);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(789, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 589);
            this.panel1.TabIndex = 0;
            // 
            // logoutLink
            // 
            this.logoutLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.logoutLink.AutoSize = true;
            this.logoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLink.LinkColor = System.Drawing.Color.White;
            this.logoutLink.Location = new System.Drawing.Point(38, 521);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(80, 20);
            this.logoutLink.TabIndex = 8;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "LOG OUT";
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // viewProductsLink
            // 
            this.viewProductsLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.viewProductsLink.AutoSize = true;
            this.viewProductsLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProductsLink.LinkColor = System.Drawing.Color.White;
            this.viewProductsLink.Location = new System.Drawing.Point(38, 390);
            this.viewProductsLink.Name = "viewProductsLink";
            this.viewProductsLink.Size = new System.Drawing.Size(144, 20);
            this.viewProductsLink.TabIndex = 5;
            this.viewProductsLink.TabStop = true;
            this.viewProductsLink.Text = "VIEW PRODUCTS";
            this.viewProductsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewProductsLink_LinkClicked);
            // 
            // checkoutLink
            // 
            this.checkoutLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.checkoutLink.AutoSize = true;
            this.checkoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutLink.LinkColor = System.Drawing.Color.White;
            this.checkoutLink.Location = new System.Drawing.Point(38, 476);
            this.checkoutLink.Name = "checkoutLink";
            this.checkoutLink.Size = new System.Drawing.Size(97, 20);
            this.checkoutLink.TabIndex = 6;
            this.checkoutLink.TabStop = true;
            this.checkoutLink.Text = "CHECKOUT";
            this.checkoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.checkoutLink_LinkClicked);
            // 
            // myOrdersLink
            // 
            this.myOrdersLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.myOrdersLink.AutoSize = true;
            this.myOrdersLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myOrdersLink.LinkColor = System.Drawing.Color.White;
            this.myOrdersLink.Location = new System.Drawing.Point(38, 432);
            this.myOrdersLink.Name = "myOrdersLink";
            this.myOrdersLink.Size = new System.Drawing.Size(107, 20);
            this.myOrdersLink.TabIndex = 7;
            this.myOrdersLink.TabStop = true;
            this.myOrdersLink.Text = "MY ORDERS";
            this.myOrdersLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.myOrdersLink_LinkClicked);
            // 
            // panelProducts
            // 
            this.panelProducts.Location = new System.Drawing.Point(-1, 0);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(793, 589);
            this.panelProducts.TabIndex = 1;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 589);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel viewProductsLink;
        private System.Windows.Forms.LinkLabel checkoutLink;
        private System.Windows.Forms.LinkLabel myOrdersLink;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel logoutLink;
    }
}