namespace DBMS_Assignment
{
    partial class Employee
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbFamily = new System.Windows.Forms.ComboBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbChild = new System.Windows.Forms.ComboBox();
            this.lblFamily = new System.Windows.Forms.Label();
            this.lblChild = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.DateWork = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDateWork = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pnEmInfo = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnEmInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 494);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1680, 436);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtEmployee
            // 
            this.txtEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployee.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee.Location = new System.Drawing.Point(83, 95);
            this.txtEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(213, 43);
            this.txtEmployee.TabIndex = 2;
            // 
            // cbSex
            // 
            this.cbSex.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(312, 88);
            this.cbSex.Margin = new System.Windows.Forms.Padding(2);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(123, 50);
            this.cbSex.TabIndex = 3;
            // 
            // dateBirth
            // 
            this.dateBirth.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBirth.Location = new System.Drawing.Point(449, 88);
            this.dateBirth.Margin = new System.Windows.Forms.Padding(2);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(287, 50);
            this.dateBirth.TabIndex = 4;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(751, 88);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(164, 50);
            this.cbStatus.TabIndex = 5;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(75, 44);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 42);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "ឈ្មោះបុគ្គលិក";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSex.Location = new System.Drawing.Point(305, 44);
            this.lblSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(58, 42);
            this.lblSex.TabIndex = 13;
            this.lblSex.Text = "ភេទ";
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBirth.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDateBirth.Location = new System.Drawing.Point(442, 44);
            this.lblDateBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(162, 42);
            this.lblDateBirth.TabIndex = 14;
            this.lblDateBirth.Text = "ថ្ងៃខែឆ្នាំកំណើត";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStatus.Location = new System.Drawing.Point(744, 44);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(106, 42);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "ស្ថានភាព";
            // 
            // cbFamily
            // 
            this.cbFamily.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFamily.FormattingEnabled = true;
            this.cbFamily.Location = new System.Drawing.Point(929, 88);
            this.cbFamily.Margin = new System.Windows.Forms.Padding(2);
            this.cbFamily.Name = "cbFamily";
            this.cbFamily.Size = new System.Drawing.Size(144, 50);
            this.cbFamily.TabIndex = 16;
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(82, 259);
            this.cbRole.Margin = new System.Windows.Forms.Padding(2);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(353, 50);
            this.cbRole.TabIndex = 19;
            // 
            // cbChild
            // 
            this.cbChild.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChild.FormattingEnabled = true;
            this.cbChild.Location = new System.Drawing.Point(1088, 88);
            this.cbChild.Margin = new System.Windows.Forms.Padding(2);
            this.cbChild.Name = "cbChild";
            this.cbChild.Size = new System.Drawing.Size(139, 50);
            this.cbChild.TabIndex = 20;
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamily.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFamily.Location = new System.Drawing.Point(922, 44);
            this.lblFamily.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(130, 42);
            this.lblFamily.TabIndex = 21;
            this.lblFamily.Text = "មានប្ដីប្រពន្ធ";
            // 
            // lblChild
            // 
            this.lblChild.AutoSize = true;
            this.lblChild.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChild.ForeColor = System.Drawing.SystemColors.Window;
            this.lblChild.Location = new System.Drawing.Point(1081, 44);
            this.lblChild.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(98, 42);
            this.lblChild.TabIndex = 22;
            this.lblChild.Text = "ចំនួនកូន";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.Window;
            this.lblRole.Location = new System.Drawing.Point(75, 215);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(74, 42);
            this.lblRole.TabIndex = 23;
            this.lblRole.Text = "តួនាទី";
            // 
            // DateWork
            // 
            this.DateWork.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateWork.Location = new System.Drawing.Point(449, 260);
            this.DateWork.Margin = new System.Windows.Forms.Padding(2);
            this.DateWork.Name = "DateWork";
            this.DateWork.Size = new System.Drawing.Size(287, 50);
            this.DateWork.TabIndex = 25;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(751, 266);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(231, 43);
            this.txtPhone.TabIndex = 26;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(999, 266);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(228, 100);
            this.txtAddress.TabIndex = 27;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPhone.Location = new System.Drawing.Point(744, 215);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(130, 42);
            this.lblPhone.TabIndex = 28;
            this.lblPhone.Text = "លេខទូរស័ព្ទ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAddress.Location = new System.Drawing.Point(992, 215);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(130, 42);
            this.lblAddress.TabIndex = 29;
            this.lblAddress.Text = "អាស័យដ្ឋាន";
            // 
            // lblDateWork
            // 
            this.lblDateWork.AutoSize = true;
            this.lblDateWork.Font = new System.Drawing.Font("Khmer OS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateWork.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDateWork.Location = new System.Drawing.Point(442, 215);
            this.lblDateWork.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateWork.Name = "lblDateWork";
            this.lblDateWork.Size = new System.Drawing.Size(186, 42);
            this.lblDateWork.TabIndex = 30;
            this.lblDateWork.Text = "ថ្ងៃខែឆ្នាំចូលធ្វើការ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1231, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpload.Font = new System.Drawing.Font("Khmer OS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpload.Location = new System.Drawing.Point(1459, 88);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(111, 50);
            this.btnUpload.TabIndex = 32;
            this.btnUpload.Text = "បញ្ចូល";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // pnEmInfo
            // 
            this.pnEmInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnEmInfo.Controls.Add(this.btnSave);
            this.pnEmInfo.Controls.Add(this.btnDelete);
            this.pnEmInfo.Controls.Add(this.btnUpdate);
            this.pnEmInfo.Controls.Add(this.btnAdd);
            this.pnEmInfo.Controls.Add(this.btnUpload);
            this.pnEmInfo.Controls.Add(this.pictureBox1);
            this.pnEmInfo.Controls.Add(this.lblDateWork);
            this.pnEmInfo.Controls.Add(this.lblAddress);
            this.pnEmInfo.Controls.Add(this.lblPhone);
            this.pnEmInfo.Controls.Add(this.txtAddress);
            this.pnEmInfo.Controls.Add(this.txtPhone);
            this.pnEmInfo.Controls.Add(this.DateWork);
            this.pnEmInfo.Controls.Add(this.lblRole);
            this.pnEmInfo.Controls.Add(this.lblChild);
            this.pnEmInfo.Controls.Add(this.lblFamily);
            this.pnEmInfo.Controls.Add(this.cbChild);
            this.pnEmInfo.Controls.Add(this.cbRole);
            this.pnEmInfo.Controls.Add(this.cbFamily);
            this.pnEmInfo.Controls.Add(this.lblStatus);
            this.pnEmInfo.Controls.Add(this.lblDateBirth);
            this.pnEmInfo.Controls.Add(this.lblSex);
            this.pnEmInfo.Controls.Add(this.lblName);
            this.pnEmInfo.Controls.Add(this.cbStatus);
            this.pnEmInfo.Controls.Add(this.dateBirth);
            this.pnEmInfo.Controls.Add(this.cbSex);
            this.pnEmInfo.Controls.Add(this.txtEmployee);
            this.pnEmInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEmInfo.Location = new System.Drawing.Point(0, 0);
            this.pnEmInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pnEmInfo.Name = "pnEmInfo";
            this.pnEmInfo.Size = new System.Drawing.Size(1680, 494);
            this.pnEmInfo.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.Font = new System.Drawing.Font("Khmer OS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(1459, 316);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 50);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "រក្សារទុក";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Khmer OS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(1459, 260);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 50);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Khmer OS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(1459, 202);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 50);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "កែរ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Purple;
            this.btnAdd.Font = new System.Drawing.Font("Khmer OS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(1459, 145);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 50);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "បន្ថែម";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1680, 930);
            this.Controls.Add(this.pnEmInfo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnEmInfo.ResumeLayout(false);
            this.pnEmInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbFamily;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.ComboBox cbChild;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.DateTimePicker DateWork;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDateWork;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Panel pnEmInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}