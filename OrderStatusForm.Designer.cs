namespace Ecommerce_App
{
    partial class OrderStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderStatusForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrdStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.doneBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHANGE ORDER STATUS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbOrdStatus
            // 
            this.cmbOrdStatus.FormattingEnabled = true;
            this.cmbOrdStatus.Items.AddRange(new object[] {
            "Not Processed",
            "Processing",
            "Shipped",
            "Delivered",
            "Cancelled"});
            this.cmbOrdStatus.Location = new System.Drawing.Point(37, 145);
            this.cmbOrdStatus.Name = "cmbOrdStatus";
            this.cmbOrdStatus.Size = new System.Drawing.Size(391, 28);
            this.cmbOrdStatus.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Change Status:";
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doneBtn.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doneBtn.Location = new System.Drawing.Point(353, 189);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 30);
            this.doneBtn.TabIndex = 3;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // OrderStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 245);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOrdStatus);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderStatusForm";
            this.Text = "Order Status";
            this.Load += new System.EventHandler(this.OrderStatusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrdStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button doneBtn;
    }
}