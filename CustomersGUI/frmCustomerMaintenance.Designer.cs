namespace CustomersGUI
{
    partial class frmCustomerMaintenance
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
            txtCustomerID = new TextBox();
            btnGetCustomer = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtZipCode = new TextBox();
            btnAdd = new Button();
            btnModify = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            dgvIncidents = new DataGridView();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvIncidents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 24);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 0;
            label1.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(150, 24);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(96, 29);
            txtCustomerID.TabIndex = 1;
            txtCustomerID.Tag = "Customer ID";
            // 
            // btnGetCustomer
            // 
            btnGetCustomer.Location = new Point(303, 18);
            btnGetCustomer.Name = "btnGetCustomer";
            btnGetCustomer.Size = new Size(153, 37);
            btnGetCustomer.TabIndex = 2;
            btnGetCustomer.Text = "&Get Customer";
            btnGetCustomer.UseVisualStyleBackColor = true;
            btnGetCustomer.Click += btnGetCustomer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 86);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 144);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 4;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 191);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 5;
            label4.Text = "City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 242);
            label5.Name = "label5";
            label5.Size = new Size(47, 21);
            label5.TabIndex = 6;
            label5.Text = "State:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 242);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 7;
            label6.Text = "Zip Code:";
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(448, 29);
            txtName.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(153, 138);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(445, 29);
            txtAddress.TabIndex = 9;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(153, 188);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(445, 29);
            txtCity.TabIndex = 10;
            // 
            // txtState
            // 
            txtState.Location = new Point(153, 239);
            txtState.Name = "txtState";
            txtState.Size = new Size(118, 29);
            txtState.TabIndex = 11;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(431, 239);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(167, 29);
            txtZipCode.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(44, 298);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 36);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(186, 298);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(122, 36);
            btnModify.TabIndex = 14;
            btnModify.Text = "&Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(330, 298);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 36);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(476, 298);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(122, 36);
            btnExit.TabIndex = 16;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvIncidents
            // 
            dgvIncidents.BackgroundColor = Color.White;
            dgvIncidents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncidents.Location = new Point(633, 86);
            dgvIncidents.Name = "dgvIncidents";
            dgvIncidents.RowHeadersWidth = 51;
            dgvIncidents.Size = new Size(502, 200);
            dgvIncidents.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(630, 31);
            label7.Name = "label7";
            label7.Size = new Size(152, 21);
            label7.TabIndex = 18;
            label7.Text = "Customer's Incidents:";
            // 
            // frmCustomerMaintenance
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 628);
            Controls.Add(label7);
            Controls.Add(dgvIncidents);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(txtZipCode);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnGetCustomer);
            Controls.Add(txtCustomerID);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCustomerMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCustomerMaintenance";
            Load += frmCustomerMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIncidents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerID;
        private Button btnGetCustomer;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtZipCode;
        private Button btnAdd;
        private Button btnModify;
        private Button btnDelete;
        private Button btnExit;
        private DataGridView dgvIncidents;
        private Label label7;
    }
}