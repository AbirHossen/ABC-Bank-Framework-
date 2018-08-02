namespace FinalABC
{
    partial class LoanPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanPayment));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAccountNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPaymentMonth = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPaymentAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnDetails = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(37, 111);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(157, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Account Number:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(71, 211);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(66, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Name:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(37, 311);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(148, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Payment Month:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(37, 411);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(160, 24);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Payment Amount:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Depth = 0;
            this.txtAccountNumber.Hint = "";
            this.txtAccountNumber.Location = new System.Drawing.Point(200, 111);
            this.txtAccountNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PasswordChar = '\0';
            this.txtAccountNumber.SelectedText = "";
            this.txtAccountNumber.SelectionLength = 0;
            this.txtAccountNumber.SelectionStart = 0;
            this.txtAccountNumber.Size = new System.Drawing.Size(316, 28);
            this.txtAccountNumber.TabIndex = 4;
            this.txtAccountNumber.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(200, 211);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(316, 28);
            this.txtName.TabIndex = 5;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtPaymentMonth
            // 
            this.txtPaymentMonth.Depth = 0;
            this.txtPaymentMonth.Hint = "";
            this.txtPaymentMonth.Location = new System.Drawing.Point(200, 307);
            this.txtPaymentMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPaymentMonth.Name = "txtPaymentMonth";
            this.txtPaymentMonth.PasswordChar = '\0';
            this.txtPaymentMonth.SelectedText = "";
            this.txtPaymentMonth.SelectionLength = 0;
            this.txtPaymentMonth.SelectionStart = 0;
            this.txtPaymentMonth.Size = new System.Drawing.Size(316, 28);
            this.txtPaymentMonth.TabIndex = 6;
            this.txtPaymentMonth.UseSystemPasswordChar = false;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Depth = 0;
            this.txtPaymentAmount.Hint = "";
            this.txtPaymentAmount.Location = new System.Drawing.Point(200, 411);
            this.txtPaymentAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.PasswordChar = '\0';
            this.txtPaymentAmount.SelectedText = "";
            this.txtPaymentAmount.SelectionLength = 0;
            this.txtPaymentAmount.SelectionStart = 0;
            this.txtPaymentAmount.Size = new System.Drawing.Size(316, 28);
            this.txtPaymentAmount.TabIndex = 7;
            this.txtPaymentAmount.UseSystemPasswordChar = false;
            // 
            // btnDetails
            // 
            this.btnDetails.Depth = 0;
            this.btnDetails.Location = new System.Drawing.Point(550, 145);
            this.btnDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Primary = true;
            this.btnDetails.Size = new System.Drawing.Size(141, 81);
            this.btnDetails.TabIndex = 8;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(139, 487);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(146, 87);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(450, 487);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(146, 87);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // LoanPayment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(712, 604);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.txtPaymentMonth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoanPayment";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Loan Payment Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAccountNumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPaymentMonth;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPaymentAmount;
        private MaterialSkin.Controls.MaterialRaisedButton btnDetails;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
    }
}