namespace DBMS_Assignment
{
    partial class CustomerForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNumberPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtNumberPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.pnCustomer = new System.Windows.Forms.Panel();
            this.DGCustomer = new System.Windows.Forms.DataGridView();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.pnCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(353, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 42);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "ឈ្មោះ";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduct.Location = new System.Drawing.Point(735, 201);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(74, 42);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "ទំនិញ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddress.Location = new System.Drawing.Point(735, 135);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(130, 42);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "អាស័យដ្ឋាន";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(735, 71);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 42);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblNumberPhone
            // 
            this.lblNumberPhone.AutoSize = true;
            this.lblNumberPhone.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumberPhone.Location = new System.Drawing.Point(355, 184);
            this.lblNumberPhone.Name = "lblNumberPhone";
            this.lblNumberPhone.Size = new System.Drawing.Size(130, 42);
            this.lblNumberPhone.TabIndex = 6;
            this.lblNumberPhone.Text = "លេខទូរស័ព្ទ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGender.Location = new System.Drawing.Point(355, 128);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(58, 42);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "ភេទ";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(516, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 50);
            this.txtName.TabIndex = 8;
            // 
            // txtGender
            // 
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGender.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(516, 126);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(201, 50);
            this.txtGender.TabIndex = 9;
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberPhone.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberPhone.Location = new System.Drawing.Point(516, 182);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Size = new System.Drawing.Size(201, 50);
            this.txtNumberPhone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(870, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 50);
            this.txtEmail.TabIndex = 11;
            // 
            // cbProduct
            // 
            this.cbProduct.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(871, 198);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(236, 50);
            this.cbProduct.TabIndex = 13;
            // 
            // pnCustomer
            // 
            this.pnCustomer.Controls.Add(this.txtAddress);
            this.pnCustomer.Controls.Add(this.txtName);
            this.pnCustomer.Controls.Add(this.cbProduct);
            this.pnCustomer.Controls.Add(this.lblName);
            this.pnCustomer.Controls.Add(this.txtEmail);
            this.pnCustomer.Controls.Add(this.lblProduct);
            this.pnCustomer.Controls.Add(this.txtNumberPhone);
            this.pnCustomer.Controls.Add(this.lblAddress);
            this.pnCustomer.Controls.Add(this.txtGender);
            this.pnCustomer.Controls.Add(this.lblEmail);
            this.pnCustomer.Controls.Add(this.lblNumberPhone);
            this.pnCustomer.Controls.Add(this.lblGender);
            this.pnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCustomer.Location = new System.Drawing.Point(0, 0);
            this.pnCustomer.Name = "pnCustomer";
            this.pnCustomer.Size = new System.Drawing.Size(1664, 475);
            this.pnCustomer.TabIndex = 14;
            // 
            // DGCustomer
            // 
            this.DGCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGCustomer.Location = new System.Drawing.Point(0, 475);
            this.DGCustomer.Name = "DGCustomer";
            this.DGCustomer.Size = new System.Drawing.Size(1664, 416);
            this.DGCustomer.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(871, 133);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(236, 50);
            this.txtAddress.TabIndex = 14;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 891);
            this.Controls.Add(this.DGCustomer);
            this.Controls.Add(this.pnCustomer);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.pnCustomer.ResumeLayout(false);
            this.pnCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNumberPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtNumberPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Panel pnCustomer;
        private System.Windows.Forms.DataGridView DGCustomer;
        private System.Windows.Forms.TextBox txtAddress;
    }
}