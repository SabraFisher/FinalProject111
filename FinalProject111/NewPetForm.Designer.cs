namespace FinalProject111
{
    partial class NewPetForm
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
            lblWelcome = new Label();
            gbPet = new GroupBox();
            btnSave = new Button();
            txtAge = new TextBox();
            lblAge = new Label();
            txtColor = new TextBox();
            lblColorHeading = new Label();
            txtSpecies = new TextBox();
            lblSpeciesHeading = new Label();
            txtName = new TextBox();
            lblNameHeading = new Label();
            btnClear = new Button();
            gbPet.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(12, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(155, 17);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to the Family!";
            // 
            // gbPet
            // 
            gbPet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbPet.AutoSize = true;
            gbPet.Controls.Add(btnClear);
            gbPet.Controls.Add(btnSave);
            gbPet.Controls.Add(txtAge);
            gbPet.Controls.Add(lblAge);
            gbPet.Controls.Add(txtColor);
            gbPet.Controls.Add(lblColorHeading);
            gbPet.Controls.Add(txtSpecies);
            gbPet.Controls.Add(lblSpeciesHeading);
            gbPet.Controls.Add(txtName);
            gbPet.Controls.Add(lblNameHeading);
            gbPet.Location = new Point(12, 41);
            gbPet.Name = "gbPet";
            gbPet.Size = new Size(419, 202);
            gbPet.TabIndex = 0;
            gbPet.TabStop = false;
            gbPet.Text = "Pet Information";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Location = new Point(6, 152);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 28);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            txtAge.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAge.Location = new Point(58, 114);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(355, 23);
            txtAge.TabIndex = 4;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(6, 117);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 0;
            lblAge.Text = "Age";
            // 
            // txtColor
            // 
            txtColor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtColor.Location = new Point(58, 85);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(355, 23);
            txtColor.TabIndex = 3;
            // 
            // lblColorHeading
            // 
            lblColorHeading.AutoSize = true;
            lblColorHeading.Location = new Point(6, 88);
            lblColorHeading.Name = "lblColorHeading";
            lblColorHeading.Size = new Size(36, 15);
            lblColorHeading.TabIndex = 0;
            lblColorHeading.Text = "Color";
            // 
            // txtSpecies
            // 
            txtSpecies.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSpecies.Location = new Point(58, 56);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(355, 23);
            txtSpecies.TabIndex = 2;
            // 
            // lblSpeciesHeading
            // 
            lblSpeciesHeading.AutoSize = true;
            lblSpeciesHeading.Location = new Point(6, 59);
            lblSpeciesHeading.Name = "lblSpeciesHeading";
            lblSpeciesHeading.Size = new Size(46, 15);
            lblSpeciesHeading.TabIndex = 0;
            lblSpeciesHeading.Text = "Species";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(58, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(355, 23);
            txtName.TabIndex = 1;
            // 
            // lblNameHeading
            // 
            lblNameHeading.AutoSize = true;
            lblNameHeading.Location = new Point(6, 30);
            lblNameHeading.Name = "lblNameHeading";
            lblNameHeading.Size = new Size(39, 15);
            lblNameHeading.TabIndex = 0;
            lblNameHeading.Text = "Name";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(312, 156);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // NewPetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 247);
            Controls.Add(gbPet);
            Controls.Add(lblWelcome);
            Name = "NewPetForm";
            Text = "New Pet Registration Form";
            gbPet.ResumeLayout(false);
            gbPet.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private GroupBox gbPet;
        private TextBox txtName;
        private Label lblNameHeading;
        private TextBox txtColor;
        private Label lblColorHeading;
        private TextBox txtSpecies;
        private Label lblSpeciesHeading;
        private TextBox txtAge;
        private Label lblAge;
        private Button btnSave;
        private Button btnClear;
    }
}