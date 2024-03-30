namespace ApplicationForm
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtSqlAddress = new TextBox();
            label2 = new Label();
            txtSQLitePath = new TextBox();
            btnBrowseSQLitePath = new Button();
            btnStart = new Button();
            saveFileDialog1 = new SaveFileDialog();
            label3 = new Label();
            cboDatabases = new ComboBox();
            btnSet = new Button();
            pbrProgress = new ProgressBar();
            lblMessage = new Label();
            btnCancel = new Button();
            cbxEncrypt = new CheckBox();
            txtPassword = new TextBox();
            cbxIntegrated = new CheckBox();
            txtUserDB = new TextBox();
            txtPassDB = new TextBox();
            lblUser = new Label();
            lblPassword = new Label();
            cbxTriggers = new CheckBox();
            cbxCreateViews = new CheckBox();
            chkBox_treatGuidAsString = new CheckBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "SQL Server Address:";
            // 
            // txtSqlAddress
            // 
            txtSqlAddress.Location = new Point(205, 26);
            txtSqlAddress.Margin = new Padding(4, 5, 4, 5);
            txtSqlAddress.Name = "txtSqlAddress";
            txtSqlAddress.Size = new Size(571, 27);
            txtSqlAddress.TabIndex = 1;
            txtSqlAddress.Text = ".\\SQLEXPRESS";
            txtSqlAddress.TextChanged += txtSqlAddress_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 10;
            label2.Text = "SQLite Database File Path:";
            // 
            // txtSQLitePath
            // 
            txtSQLitePath.Location = new Point(205, 151);
            txtSQLitePath.Margin = new Padding(4, 5, 4, 5);
            txtSQLitePath.Name = "txtSQLitePath";
            txtSQLitePath.Size = new Size(571, 27);
            txtSQLitePath.TabIndex = 11;
            txtSQLitePath.TextChanged += txtSQLitePath_TextChanged;
            // 
            // btnBrowseSQLitePath
            // 
            btnBrowseSQLitePath.Location = new Point(785, 148);
            btnBrowseSQLitePath.Margin = new Padding(4, 5, 4, 5);
            btnBrowseSQLitePath.Name = "btnBrowseSQLitePath";
            btnBrowseSQLitePath.Size = new Size(100, 35);
            btnBrowseSQLitePath.TabIndex = 12;
            btnBrowseSQLitePath.Text = "Browse...";
            btnBrowseSQLitePath.UseVisualStyleBackColor = true;
            btnBrowseSQLitePath.Click += btnBrowseSQLitePath_Click;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnStart.Location = new Point(621, 331);
            btnStart.Margin = new Padding(4, 5, 4, 5);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(264, 35);
            btnStart.TabIndex = 17;
            btnStart.Text = "Start The Conversion Process";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "db";
            saveFileDialog1.Filter = "SQLite Files|*.db|All Files|*.*";
            saveFileDialog1.RestoreDirectory = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 71);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "Select DB:";
            // 
            // cboDatabases
            // 
            cboDatabases.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDatabases.Enabled = false;
            cboDatabases.FormattingEnabled = true;
            cboDatabases.Location = new Point(205, 66);
            cboDatabases.Margin = new Padding(4, 5, 4, 5);
            cboDatabases.Name = "cboDatabases";
            cboDatabases.Size = new Size(571, 28);
            cboDatabases.TabIndex = 4;
            cboDatabases.SelectedIndexChanged += cboDatabases_SelectedIndexChanged;
            // 
            // btnSet
            // 
            btnSet.Location = new Point(785, 22);
            btnSet.Margin = new Padding(4, 5, 4, 5);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(100, 35);
            btnSet.TabIndex = 2;
            btnSet.Text = "Set";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // pbrProgress
            // 
            pbrProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbrProgress.Location = new Point(16, 300);
            pbrProgress.Margin = new Padding(4, 5, 4, 5);
            pbrProgress.Name = "pbrProgress";
            pbrProgress.Size = new Size(869, 28);
            pbrProgress.TabIndex = 16;
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMessage.Location = new Point(16, 272);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(705, 20);
            lblMessage.TabIndex = 15;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Location = new Point(486, 331);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 35);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbxEncrypt
            // 
            cbxEncrypt.AutoSize = true;
            cbxEncrypt.Location = new Point(20, 195);
            cbxEncrypt.Margin = new Padding(4, 5, 4, 5);
            cbxEncrypt.Name = "cbxEncrypt";
            cbxEncrypt.Size = new Size(171, 24);
            cbxEncrypt.TabIndex = 13;
            cbxEncrypt.Text = "Encryption password:";
            cbxEncrypt.UseVisualStyleBackColor = true;
            cbxEncrypt.CheckedChanged += cbxEncrypt_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(205, 192);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(261, 27);
            txtPassword.TabIndex = 14;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // cbxIntegrated
            // 
            cbxIntegrated.Checked = true;
            cbxIntegrated.CheckState = CheckState.Checked;
            cbxIntegrated.Location = new Point(20, 109);
            cbxIntegrated.Margin = new Padding(4, 5, 4, 5);
            cbxIntegrated.Name = "cbxIntegrated";
            cbxIntegrated.Size = new Size(173, 32);
            cbxIntegrated.TabIndex = 5;
            cbxIntegrated.Text = "Integrated security";
            cbxIntegrated.UseVisualStyleBackColor = true;
            cbxIntegrated.CheckedChanged += ChkIntegratedCheckedChanged;
            // 
            // txtUserDB
            // 
            txtUserDB.Location = new Point(252, 109);
            txtUserDB.Margin = new Padding(4, 5, 4, 5);
            txtUserDB.Name = "txtUserDB";
            txtUserDB.Size = new Size(132, 27);
            txtUserDB.TabIndex = 7;
            txtUserDB.Visible = false;
            // 
            // txtPassDB
            // 
            txtPassDB.Location = new Point(472, 109);
            txtPassDB.Margin = new Padding(4, 5, 4, 5);
            txtPassDB.Name = "txtPassDB";
            txtPassDB.PasswordChar = '*';
            txtPassDB.Size = new Size(149, 27);
            txtPassDB.TabIndex = 9;
            txtPassDB.Visible = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(201, 114);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(41, 20);
            lblUser.TabIndex = 6;
            lblUser.Text = "User:";
            lblUser.Visible = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(393, 114);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password:";
            lblPassword.Visible = false;
            // 
            // cbxTriggers
            // 
            cbxTriggers.AutoSize = true;
            cbxTriggers.Location = new Point(20, 232);
            cbxTriggers.Margin = new Padding(4, 5, 4, 5);
            cbxTriggers.Name = "cbxTriggers";
            cbxTriggers.Size = new Size(280, 24);
            cbxTriggers.TabIndex = 19;
            cbxTriggers.Text = "Create triggers enforcing foreign keys";
            cbxTriggers.UseVisualStyleBackColor = true;
            // 
            // cbxCreateViews
            // 
            cbxCreateViews.AutoSize = true;
            cbxCreateViews.Location = new Point(296, 232);
            cbxCreateViews.Margin = new Padding(4, 5, 4, 5);
            cbxCreateViews.Name = "cbxCreateViews";
            cbxCreateViews.Size = new Size(340, 24);
            cbxCreateViews.TabIndex = 20;
            cbxCreateViews.Text = "Try to create views (works only in simple cases)";
            cbxCreateViews.UseVisualStyleBackColor = true;
            // 
            // chkBox_treatGuidAsString
            // 
            chkBox_treatGuidAsString.AutoSize = true;
            chkBox_treatGuidAsString.Location = new Point(623, 232);
            chkBox_treatGuidAsString.Margin = new Padding(4, 5, 4, 5);
            chkBox_treatGuidAsString.Name = "chkBox_treatGuidAsString";
            chkBox_treatGuidAsString.Size = new Size(166, 24);
            chkBox_treatGuidAsString.TabIndex = 21;
            chkBox_treatGuidAsString.Text = "Treat GUID As String";
            chkBox_treatGuidAsString.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(247, 80);
            contextMenuStrip1.Text = "Select";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(246, 24);
            toolStripMenuItem1.Text = "(localdb)\\MSSQLLocalDB";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(246, 24);
            toolStripMenuItem2.Text = ".\\SQLEXPRESS";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 372);
            Controls.Add(chkBox_treatGuidAsString);
            Controls.Add(cbxCreateViews);
            Controls.Add(cbxTriggers);
            Controls.Add(txtPassDB);
            Controls.Add(txtUserDB);
            Controls.Add(cbxIntegrated);
            Controls.Add(txtPassword);
            Controls.Add(cbxEncrypt);
            Controls.Add(btnCancel);
            Controls.Add(lblMessage);
            Controls.Add(pbrProgress);
            Controls.Add(btnSet);
            Controls.Add(cboDatabases);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Controls.Add(label3);
            Controls.Add(btnStart);
            Controls.Add(btnBrowseSQLitePath);
            Controls.Add(txtSQLitePath);
            Controls.Add(label2);
            Controls.Add(txtSqlAddress);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "SQL Server To SQLite DB Converter";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPassDB;
        private System.Windows.Forms.TextBox txtUserDB;
        private System.Windows.Forms.CheckBox cbxIntegrated;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSqlAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSQLitePath;
        private System.Windows.Forms.Button btnBrowseSQLitePath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDatabases;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.ProgressBar pbrProgress;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbxEncrypt;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbxTriggers;
        private System.Windows.Forms.CheckBox cbxCreateViews;
        private System.Windows.Forms.CheckBox chkBox_treatGuidAsString;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}

