namespace FinalABC
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAccount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBalance = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnDetails = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDeposit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(65, 112);
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
            this.materialLabel2.Location = new System.Drawing.Point(156, 241);
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
            this.materialLabel3.Location = new System.Drawing.Point(75, 359);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(147, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Current Balance:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(141, 498);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(81, 24);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Amount:";
            // 
            // txtAccount
            // 
            this.txtAccount.Depth = 0;
            this.txtAccount.Hint = "";
            this.txtAccount.Location = new System.Drawing.Point(267, 108);
            this.txtAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.PasswordChar = '\0';
            this.txtAccount.SelectedText = "";
            this.txtAccount.SelectionLength = 0;
            this.txtAccount.SelectionStart = 0;
            this.txtAccount.Size = new System.Drawing.Size(350, 28);
            this.txtAccount.TabIndex = 4;
            this.txtAccount.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(267, 237);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(350, 28);
            this.txtName.TabIndex = 5;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtBalance
            // 
            this.txtBalance.Depth = 0;
            this.txtBalance.Hint = "";
            this.txtBalance.Location = new System.Drawing.Point(267, 359);
            this.txtBalance.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PasswordChar = '\0';
            this.txtBalance.SelectedText = "";
            this.txtBalance.SelectionLength = 0;
            this.txtBalance.SelectionStart = 0;
            this.txtBalance.Size = new System.Drawing.Size(350, 28);
            this.txtBalance.TabIndex = 6;
            this.txtBalance.UseSystemPasswordChar = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Depth = 0;
            this.txtAmount.Hint = "";
            this.txtAmount.Location = new System.Drawing.Point(267, 498);
            this.txtAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.Size = new System.Drawing.Size(350, 28);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.UseSystemPasswordChar = false;
            // 
            // btnDetails
            // 
            this.btnDetails.Depth = 0;
            this.btnDetails.Location = new System.Drawing.Point(670, 84);
            this.btnDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Primary = true;
            this.btnDetails.Size = new System.Drawing.Size(129, 83);
            this.btnDetails.TabIndex = 8;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Depth = 0;
            this.btnDeposit.Location = new System.Drawing.Point(229, 600);
            this.btnDeposit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Primary = true;
            this.btnDeposit.Size = new System.Drawing.Size(129, 83);
            this.btnDeposit.TabIndex = 9;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(518, 600);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(129, 83);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Deposit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(878, 706);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Deposit";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAccount;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBalance;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAmount;
        private MaterialSkin.Controls.MaterialRaisedButton btnDetails;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeposit;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
    }
}