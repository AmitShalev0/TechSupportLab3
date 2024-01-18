namespace CustomersGUI
{
    partial class frmAddModifyCustomer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            cboState = new ComboBox();
            txtZipCode = new TextBox();
            btnAccept = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 78);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 1;
            label2.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 132);
            label3.Name = "label3";
            label3.Size = new Size(50, 28);
            label3.TabIndex = 2;
            label3.Text = "City:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 188);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 3;
            label4.Text = "State:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 188);
            label5.Name = "label5";
            label5.Size = new Size(92, 28);
            label5.TabIndex = 4;
            label5.Text = "Zip code:";
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 24);
            txtName.MaxLength = 100;
            txtName.Name = "txtName";
            txtName.Size = new Size(446, 34);
            txtName.TabIndex = 5;
            txtName.Tag = "Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(133, 75);
            txtAddress.MaxLength = 50;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(446, 34);
            txtAddress.TabIndex = 6;
            txtAddress.Tag = "Address";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(133, 129);
            txtCity.MaxLength = 20;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(446, 34);
            txtCity.TabIndex = 7;
            txtCity.Tag = "City";
            // 
            // cboState
            // 
            cboState.FormattingEnabled = true;
            cboState.Location = new Point(133, 185);
            cboState.Name = "cboState";
            cboState.Size = new Size(182, 36);
            cboState.TabIndex = 8;
            cboState.Tag = "State";
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(430, 185);
            txtZipCode.MaxLength = 15;
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(149, 34);
            txtZipCode.TabIndex = 9;
            txtZipCode.Tag = "Zip code";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(73, 241);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(113, 37);
            btnAccept.TabIndex = 10;
            btnAccept.Text = "&Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(444, 241);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 37);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddModifyCustomer
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(625, 304);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(txtZipCode);
            Controls.Add(cboState);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmAddModifyCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddModifyCustomer";
            Load += frmAddModifyCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtCity;
        private ComboBox cboState;
        private TextBox txtZipCode;
        private Button btnAccept;
        private Button btnCancel;
    }
}