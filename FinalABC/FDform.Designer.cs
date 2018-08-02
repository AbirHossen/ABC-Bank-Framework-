namespace FinalABC
{
    partial class FDform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDform));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAccountNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPeriod = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtInterest = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.radFlexi = new MaterialSkin.Controls.MaterialRadioButton();
            this.radRegular = new MaterialSkin.Controls.MaterialRadioButton();
            this.radFiverYear = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(31, 163);
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
            this.materialLabel2.Location = new System.Drawing.Point(132, 265);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(56, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Type:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(107, 359);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(81, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Amount:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(65, 459);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(137, 24);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Period(Month):";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(101, 559);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(87, 24);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Interest%";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Depth = 0;
            this.txtAccountNumber.Hint = "";
            this.txtAccountNumber.Location = new System.Drawing.Point(228, 159);
            this.txtAccountNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PasswordChar = '\0';
            this.txtAccountNumber.SelectedText = "";
            this.txtAccountNumber.SelectionLength = 0;
            this.txtAccountNumber.SelectionStart = 0;
            this.txtAccountNumber.Size = new System.Drawing.Size(349, 28);
            this.txtAccountNumber.TabIndex = 5;
            this.txtAccountNumber.UseSystemPasswordChar = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Depth = 0;
            this.txtAmount.Hint = "";
            this.txtAmount.Location = new System.Drawing.Point(228, 355);
            this.txtAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.Size = new System.Drawing.Size(349, 28);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.UseSystemPasswordChar = false;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Depth = 0;
            this.txtPeriod.Hint = "";
            this.txtPeriod.Location = new System.Drawing.Point(228, 455);
            this.txtPeriod.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.PasswordChar = '\0';
            this.txtPeriod.SelectedText = "";
            this.txtPeriod.SelectionLength = 0;
            this.txtPeriod.SelectionStart = 0;
            this.txtPeriod.Size = new System.Drawing.Size(349, 28);
            this.txtPeriod.TabIndex = 7;
            this.txtPeriod.UseSystemPasswordChar = false;
            // 
            // txtInterest
            // 
            this.txtInterest.Depth = 0;
            this.txtInterest.Hint = "";
            this.txtInterest.Location = new System.Drawing.Point(228, 555);
            this.txtInterest.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.PasswordChar = '\0';
            this.txtInterest.SelectedText = "";
            this.txtInterest.SelectionLength = 0;
            this.txtInterest.SelectionStart = 0;
            this.txtInterest.Size = new System.Drawing.Size(349, 28);
            this.txtInterest.TabIndex = 8;
            this.txtInterest.UseSystemPasswordChar = false;
            // 
            // radFlexi
            // 
            this.radFlexi.AutoSize = true;
            this.radFlexi.Depth = 0;
            this.radFlexi.Font = new System.Drawing.Font("Roboto", 10F);
            this.radFlexi.Location = new System.Drawing.Point(228, 258);
            this.radFlexi.Margin = new System.Windows.Forms.Padding(0);
            this.radFlexi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radFlexi.MouseState = MaterialSkin.MouseState.HOVER;
            this.radFlexi.Name = "radFlexi";
            this.radFlexi.Ripple = true;
            this.radFlexi.Size = new System.Drawing.Size(66, 30);
            this.radFlexi.TabIndex = 9;
            this.radFlexi.TabStop = true;
            this.radFlexi.Text = "Flexi";
            this.radFlexi.UseVisualStyleBackColor = true;
            // 
            // radRegular
            // 
            this.radRegular.AutoSize = true;
            this.radRegular.Depth = 0;
            this.radRegular.Font = new System.Drawing.Font("Roboto", 10F);
            this.radRegular.Location = new System.Drawing.Point(353, 258);
            this.radRegular.Margin = new System.Windows.Forms.Padding(0);
            this.radRegular.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radRegular.MouseState = MaterialSkin.MouseState.HOVER;
            this.radRegular.Name = "radRegular";
            this.radRegular.Ripple = true;
            this.radRegular.Size = new System.Drawing.Size(89, 30);
            this.radRegular.TabIndex = 10;
            this.radRegular.TabStop = true;
            this.radRegular.Text = "Regular";
            this.radRegular.UseVisualStyleBackColor = true;
            // 
            // radFiverYear
            // 
            this.radFiverYear.AutoSize = true;
            this.radFiverYear.Depth = 0;
            this.radFiverYear.Font = new System.Drawing.Font("Roboto", 10F);
            this.radFiverYear.Location = new System.Drawing.Point(479, 258);
            this.radFiverYear.Margin = new System.Windows.Forms.Padding(0);
            this.radFiverYear.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radFiverYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.radFiverYear.Name = "radFiverYear";
            this.radFiverYear.Ripple = true;
            this.radFiverYear.Size = new System.Drawing.Size(114, 30);
            this.radFiverYear.TabIndex = 11;
            this.radFiverYear.TabStop = true;
            this.radFiverYear.Text = "5 year plan";
            this.radFiverYear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Depth = 0;
            this.btnSubmit.Location = new System.Drawing.Point(94, 623);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Primary = true;
            this.btnSubmit.Size = new System.Drawing.Size(160, 95);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // bnCancel
            // 
            this.bnCancel.Depth = 0;
            this.bnCancel.Location = new System.Drawing.Point(417, 623);
            this.bnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Primary = true;
            this.bnCancel.Size = new System.Drawing.Size(160, 95);
            this.bnCancel.TabIndex = 13;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            // 
            // FDform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(737, 732);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.radFiverYear);
            this.Controls.Add(this.radRegular);
            this.Controls.Add(this.radFlexi);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FDform";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "FD Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAccountNumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAmount;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPeriod;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtInterest;
        private MaterialSkin.Controls.MaterialRadioButton radFlexi;
        private MaterialSkin.Controls.MaterialRadioButton radRegular;
        private MaterialSkin.Controls.MaterialRadioButton radFiverYear;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmit;
        private MaterialSkin.Controls.MaterialRaisedButton bnCancel;
    }
}