namespace ABMCollege3Guys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserNL = new System.Windows.Forms.Label();
            this.UserNTBox = new System.Windows.Forms.TextBox();
            this.PasswordTBox = new System.Windows.Forms.TextBox();
            this.PasswordL = new System.Windows.Forms.Label();
            this.NameTBox = new System.Windows.Forms.TextBox();
            this.NameL = new System.Windows.Forms.Label();
            this.ContactNTBox = new System.Windows.Forms.TextBox();
            this.ContactL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserNL
            // 
            this.UserNL.AutoSize = true;
            this.UserNL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNL.Location = new System.Drawing.Point(50, 148);
            this.UserNL.Name = "UserNL";
            this.UserNL.Size = new System.Drawing.Size(81, 21);
            this.UserNL.TabIndex = 0;
            this.UserNL.Text = "Username";
            // 
            // UserNTBox
            // 
            this.UserNTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNTBox.Location = new System.Drawing.Point(161, 145);
            this.UserNTBox.Name = "UserNTBox";
            this.UserNTBox.Size = new System.Drawing.Size(168, 29);
            this.UserNTBox.TabIndex = 1;
            // 
            // PasswordTBox
            // 
            this.PasswordTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTBox.Location = new System.Drawing.Point(161, 209);
            this.PasswordTBox.Name = "PasswordTBox";
            this.PasswordTBox.Size = new System.Drawing.Size(168, 29);
            this.PasswordTBox.TabIndex = 3;
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordL.Location = new System.Drawing.Point(50, 212);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(76, 21);
            this.PasswordL.TabIndex = 2;
            this.PasswordL.Text = "Password";
            // 
            // NameTBox
            // 
            this.NameTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTBox.Location = new System.Drawing.Point(475, 145);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.Size = new System.Drawing.Size(168, 29);
            this.NameTBox.TabIndex = 5;
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameL.Location = new System.Drawing.Point(364, 148);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(52, 21);
            this.NameL.TabIndex = 4;
            this.NameL.Text = "Name";
            // 
            // ContactNTBox
            // 
            this.ContactNTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactNTBox.Location = new System.Drawing.Point(475, 212);
            this.ContactNTBox.Name = "ContactNTBox";
            this.ContactNTBox.Size = new System.Drawing.Size(168, 29);
            this.ContactNTBox.TabIndex = 7;
            // 
            // ContactL
            // 
            this.ContactL.AutoSize = true;
            this.ContactL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactL.Location = new System.Drawing.Point(344, 215);
            this.ContactL.Name = "ContactL";
            this.ContactL.Size = new System.Drawing.Size(125, 21);
            this.ContactL.TabIndex = 6;
            this.ContactL.Text = "Contact Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 567);
            this.Controls.Add(this.ContactNTBox);
            this.Controls.Add(this.ContactL);
            this.Controls.Add(this.NameTBox);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.PasswordTBox);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.UserNTBox);
            this.Controls.Add(this.UserNL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UserNL;
        private TextBox UserNTBox;
        private TextBox PasswordTBox;
        private Label PasswordL;
        private TextBox NameTBox;
        private Label NameL;
        private TextBox ContactNTBox;
        private Label ContactL;
    }
}