namespace WFCollabProject
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
            this.UNLabel = new System.Windows.Forms.Label();
            this.UNTBox = new System.Windows.Forms.TextBox();
            this.PasswordTBox = new System.Windows.Forms.TextBox();
            this.PasswordL = new System.Windows.Forms.Label();
            this.NameTBox = new System.Windows.Forms.TextBox();
            this.NameL = new System.Windows.Forms.Label();
            this.ContactNTBox = new System.Windows.Forms.TextBox();
            this.ContactL = new System.Windows.Forms.Label();
            this.DiverseB = new System.Windows.Forms.Button();
            this.IDTBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UNLabel
            // 
            this.UNLabel.AutoSize = true;
            this.UNLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UNLabel.Location = new System.Drawing.Point(50, 197);
            this.UNLabel.Name = "UNLabel";
            this.UNLabel.Size = new System.Drawing.Size(81, 21);
            this.UNLabel.TabIndex = 0;
            this.UNLabel.Text = "Username";
            // 
            // UNTBox
            // 
            this.UNTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UNTBox.Location = new System.Drawing.Point(161, 194);
            this.UNTBox.Name = "UNTBox";
            this.UNTBox.Size = new System.Drawing.Size(168, 29);
            this.UNTBox.TabIndex = 1;
            // 
            // PasswordTBox
            // 
            this.PasswordTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTBox.Location = new System.Drawing.Point(161, 258);
            this.PasswordTBox.Name = "PasswordTBox";
            this.PasswordTBox.Size = new System.Drawing.Size(168, 29);
            this.PasswordTBox.TabIndex = 3;
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordL.Location = new System.Drawing.Point(50, 261);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(76, 21);
            this.PasswordL.TabIndex = 2;
            this.PasswordL.Text = "Password";
            // 
            // NameTBox
            // 
            this.NameTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTBox.Location = new System.Drawing.Point(475, 194);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.Size = new System.Drawing.Size(168, 29);
            this.NameTBox.TabIndex = 5;
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameL.Location = new System.Drawing.Point(364, 197);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(52, 21);
            this.NameL.TabIndex = 4;
            this.NameL.Text = "Name";
            // 
            // ContactNTBox
            // 
            this.ContactNTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactNTBox.Location = new System.Drawing.Point(475, 261);
            this.ContactNTBox.Name = "ContactNTBox";
            this.ContactNTBox.Size = new System.Drawing.Size(168, 29);
            this.ContactNTBox.TabIndex = 7;
            // 
            // ContactL
            // 
            this.ContactL.AutoSize = true;
            this.ContactL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactL.Location = new System.Drawing.Point(344, 264);
            this.ContactL.Name = "ContactL";
            this.ContactL.Size = new System.Drawing.Size(125, 21);
            this.ContactL.TabIndex = 6;
            this.ContactL.Text = "Contact Number";
            // 
            // DiverseB
            // 
            this.DiverseB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiverseB.Location = new System.Drawing.Point(344, 310);
            this.DiverseB.Name = "DiverseB";
            this.DiverseB.Size = new System.Drawing.Size(80, 43);
            this.DiverseB.TabIndex = 8;
            this.DiverseB.Text = "button1";
            this.DiverseB.UseVisualStyleBackColor = true;
            this.DiverseB.Click += new System.EventHandler(this.DiverseB_Click);
            // 
            // IDTBox
            // 
            this.IDTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDTBox.Location = new System.Drawing.Point(301, 148);
            this.IDTBox.Name = "IDTBox";
            this.IDTBox.Size = new System.Drawing.Size(168, 29);
            this.IDTBox.TabIndex = 10;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(255, 151);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(25, 21);
            this.IDLabel.TabIndex = 9;
            this.IDLabel.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Username,
            this.Password,
            this.FullName,
            this.Contact});
            this.dataGridView1.Location = new System.Drawing.Point(161, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(544, 289);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "Name";
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 677);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IDTBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.DiverseB);
            this.Controls.Add(this.ContactNTBox);
            this.Controls.Add(this.ContactL);
            this.Controls.Add(this.NameTBox);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.PasswordTBox);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.UNTBox);
            this.Controls.Add(this.UNLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UNLabel;
        private TextBox UNTBox;
        private TextBox PasswordTBox;
        private Label PasswordL;
        private TextBox NameTBox;
        private Label NameL;
        private TextBox ContactNTBox;
        private Label ContactL;
        private Button DiverseB;
        private TextBox IDTBox;
        private Label IDLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Contact;
    }
}