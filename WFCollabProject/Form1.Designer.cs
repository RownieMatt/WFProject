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
            UNLabel = new Label();
            UNTBox = new TextBox();
            PasswordTBox = new TextBox();
            PasswordL = new Label();
            NameTBox = new TextBox();
            NameL = new Label();
            ContactNTBox = new TextBox();
            ContactL = new Label();
            DiverseB = new Button();
            IDTBox = new TextBox();
            IDLabel = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            insertToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            selectToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // UNLabel
            // 
            UNLabel.AutoSize = true;
            UNLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UNLabel.Location = new Point(65, 117);
            UNLabel.Name = "UNLabel";
            UNLabel.Size = new Size(81, 21);
            UNLabel.TabIndex = 0;
            UNLabel.Text = "Username";
            // 
            // UNTBox
            // 
            UNTBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UNTBox.Location = new Point(176, 114);
            UNTBox.Name = "UNTBox";
            UNTBox.Size = new Size(168, 29);
            UNTBox.TabIndex = 1;
            // 
            // PasswordTBox
            // 
            PasswordTBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTBox.Location = new Point(176, 178);
            PasswordTBox.Name = "PasswordTBox";
            PasswordTBox.Size = new Size(168, 29);
            PasswordTBox.TabIndex = 3;
            // 
            // PasswordL
            // 
            PasswordL.AutoSize = true;
            PasswordL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordL.Location = new Point(65, 181);
            PasswordL.Name = "PasswordL";
            PasswordL.Size = new Size(76, 21);
            PasswordL.TabIndex = 2;
            PasswordL.Text = "Password";
            // 
            // NameTBox
            // 
            NameTBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameTBox.Location = new Point(490, 114);
            NameTBox.Name = "NameTBox";
            NameTBox.Size = new Size(168, 29);
            NameTBox.TabIndex = 5;
            // 
            // NameL
            // 
            NameL.AutoSize = true;
            NameL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameL.Location = new Point(379, 117);
            NameL.Name = "NameL";
            NameL.Size = new Size(52, 21);
            NameL.TabIndex = 4;
            NameL.Text = "Name";
            // 
            // ContactNTBox
            // 
            ContactNTBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactNTBox.Location = new Point(490, 181);
            ContactNTBox.Name = "ContactNTBox";
            ContactNTBox.Size = new Size(168, 29);
            ContactNTBox.TabIndex = 7;
            // 
            // ContactL
            // 
            ContactL.AutoSize = true;
            ContactL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactL.Location = new Point(359, 184);
            ContactL.Name = "ContactL";
            ContactL.Size = new Size(125, 21);
            ContactL.TabIndex = 6;
            ContactL.Text = "Contact Number";
            // 
            // DiverseB
            // 
            DiverseB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DiverseB.Location = new Point(359, 230);
            DiverseB.Name = "DiverseB";
            DiverseB.Size = new Size(80, 43);
            DiverseB.TabIndex = 8;
            DiverseB.Text = "button1";
            DiverseB.UseVisualStyleBackColor = true;
            DiverseB.Click += DiverseB_Click;
            // 
            // IDTBox
            // 
            IDTBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDTBox.Location = new Point(316, 68);
            IDTBox.Name = "IDTBox";
            IDTBox.Size = new Size(168, 29);
            IDTBox.TabIndex = 10;
            IDTBox.MouseLeave += IDTBox_MouseLeave;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(270, 71);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(25, 21);
            IDLabel.TabIndex = 9;
            IDLabel.Text = "ID";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(897, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem, selectToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(112, 22);
            insertToolStripMenuItem.Text = "Insert";
            insertToolStripMenuItem.Click += insertToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(112, 22);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(112, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // selectToolStripMenuItem
            // 
            selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            selectToolStripMenuItem.Size = new Size(112, 22);
            selectToolStripMenuItem.Text = "Select";
            selectToolStripMenuItem.Click += selectToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(112, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(698, 232);
            dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 567);
            Controls.Add(dataGridView1);
            Controls.Add(IDTBox);
            Controls.Add(IDLabel);
            Controls.Add(DiverseB);
            Controls.Add(ContactNTBox);
            Controls.Add(ContactL);
            Controls.Add(NameTBox);
            Controls.Add(NameL);
            Controls.Add(PasswordTBox);
            Controls.Add(PasswordL);
            Controls.Add(UNTBox);
            Controls.Add(UNLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem selectToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private DataGridView dataGridView1;
    }
}