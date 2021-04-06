namespace Vyachka.Encryptors
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
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.CipherTextBox = new System.Windows.Forms.TextBox();
            this.PlainTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToEncryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToDecryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.savePlainTextStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCipherTextStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.PlainTextLabel = new System.Windows.Forms.Label();
            this.CipherTextLabel = new System.Windows.Forms.Label();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.RailFenceRBtn = new System.Windows.Forms.RadioButton();
            this.ColumnRBtn = new System.Windows.Forms.RadioButton();
            this.VigenerRBtn = new System.Windows.Forms.RadioButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyTextBox.Location = new System.Drawing.Point(377, 108);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(314, 29);
            this.KeyTextBox.TabIndex = 0;
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CipherTextBox.Location = new System.Drawing.Point(377, 206);
            this.CipherTextBox.Multiline = true;
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CipherTextBox.Size = new System.Drawing.Size(314, 174);
            this.CipherTextBox.TabIndex = 1;
            // 
            // PlainTextBox
            // 
            this.PlainTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlainTextBox.Location = new System.Drawing.Point(24, 206);
            this.PlainTextBox.Multiline = true;
            this.PlainTextBox.Name = "PlainTextBox";
            this.PlainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlainTextBox.Size = new System.Drawing.Size(314, 174);
            this.PlainTextBox.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToEncryptToolStripMenuItem,
            this.openToDecryptToolStripMenuItem,
            this.toolStripSeparator1,
            this.savePlainTextStripMenuItem,
            this.saveCipherTextStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToEncryptToolStripMenuItem
            // 
            this.openToEncryptToolStripMenuItem.Name = "openToEncryptToolStripMenuItem";
            this.openToEncryptToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.openToEncryptToolStripMenuItem.Text = "Open to encrypt...";
            this.openToEncryptToolStripMenuItem.Click += new System.EventHandler(this.OpenToEncryptToolStripMenuItem_Click);
            // 
            // openToDecryptToolStripMenuItem
            // 
            this.openToDecryptToolStripMenuItem.Name = "openToDecryptToolStripMenuItem";
            this.openToDecryptToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.openToDecryptToolStripMenuItem.Text = "Open to decrypt...";
            this.openToDecryptToolStripMenuItem.Click += new System.EventHandler(this.OpenToDecryptToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // savePlainTextStripMenuItem
            // 
            this.savePlainTextStripMenuItem.Name = "savePlainTextStripMenuItem";
            this.savePlainTextStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.savePlainTextStripMenuItem.Text = "Save plain text";
            this.savePlainTextStripMenuItem.Click += new System.EventHandler(this.SavePlainTextStripMenuItem_Click);
            // 
            // saveCipherTextStripMenuItem
            // 
            this.saveCipherTextStripMenuItem.Name = "saveCipherTextStripMenuItem";
            this.saveCipherTextStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.saveCipherTextStripMenuItem.Text = "Save cipher text";
            this.saveCipherTextStripMenuItem.Click += new System.EventHandler(this.SaveCipherTextStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionToolStripMenuItem
            // 
            this.instructionToolStripMenuItem.Name = "instructionToolStripMenuItem";
            this.instructionToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.instructionToolStripMenuItem.Text = "Instruction";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyLabel.Location = new System.Drawing.Point(524, 84);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(37, 21);
            this.KeyLabel.TabIndex = 4;
            this.KeyLabel.Text = "Key";
            // 
            // PlainTextLabel
            // 
            this.PlainTextLabel.AutoSize = true;
            this.PlainTextLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlainTextLabel.Location = new System.Drawing.Point(143, 182);
            this.PlainTextLabel.Name = "PlainTextLabel";
            this.PlainTextLabel.Size = new System.Drawing.Size(85, 21);
            this.PlainTextLabel.TabIndex = 5;
            this.PlainTextLabel.Text = "Plain text:";
            // 
            // CipherTextLabel
            // 
            this.CipherTextLabel.AutoSize = true;
            this.CipherTextLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CipherTextLabel.Location = new System.Drawing.Point(487, 182);
            this.CipherTextLabel.Name = "CipherTextLabel";
            this.CipherTextLabel.Size = new System.Drawing.Size(91, 21);
            this.CipherTextLabel.TabIndex = 6;
            this.CipherTextLabel.Text = "Cipher text";
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptBtn.Location = new System.Drawing.Point(132, 386);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(96, 40);
            this.EncryptBtn.TabIndex = 7;
            this.EncryptBtn.Text = "Encrypt";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecryptBtn.Location = new System.Drawing.Point(483, 386);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(95, 40);
            this.DecryptBtn.TabIndex = 8;
            this.DecryptBtn.Text = "Decrypt";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // RailFenceRBtn
            // 
            this.RailFenceRBtn.AutoSize = true;
            this.RailFenceRBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RailFenceRBtn.Location = new System.Drawing.Point(24, 58);
            this.RailFenceRBtn.Name = "RailFenceRBtn";
            this.RailFenceRBtn.Size = new System.Drawing.Size(296, 25);
            this.RailFenceRBtn.TabIndex = 10;
            this.RailFenceRBtn.TabStop = true;
            this.RailFenceRBtn.Text = "Rail fence method(eng text\\int key)";
            this.RailFenceRBtn.UseVisualStyleBackColor = true;
            // 
            // ColumnRBtn
            // 
            this.ColumnRBtn.AutoSize = true;
            this.ColumnRBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnRBtn.Location = new System.Drawing.Point(24, 85);
            this.ColumnRBtn.Name = "ColumnRBtn";
            this.ColumnRBtn.Size = new System.Drawing.Size(188, 25);
            this.ColumnRBtn.TabIndex = 11;
            this.ColumnRBtn.TabStop = true;
            this.ColumnRBtn.Text = "Column method(eng)";
            this.ColumnRBtn.UseVisualStyleBackColor = true;
            // 
            // VigenerRBtn
            // 
            this.VigenerRBtn.AutoSize = true;
            this.VigenerRBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VigenerRBtn.Location = new System.Drawing.Point(24, 112);
            this.VigenerRBtn.Name = "VigenerRBtn";
            this.VigenerRBtn.Size = new System.Drawing.Size(185, 25);
            this.VigenerRBtn.TabIndex = 12;
            this.VigenerRBtn.TabStop = true;
            this.VigenerRBtn.Text = "Vigener method(rus)";
            this.VigenerRBtn.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.VigenerRBtn);
            this.Controls.Add(this.ColumnRBtn);
            this.Controls.Add(this.RailFenceRBtn);
            this.Controls.Add(this.DecryptBtn);
            this.Controls.Add(this.EncryptBtn);
            this.Controls.Add(this.CipherTextLabel);
            this.Controls.Add(this.PlainTextLabel);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.PlainTextBox);
            this.Controls.Add(this.CipherTextBox);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Lab_1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.TextBox CipherTextBox;
        private System.Windows.Forms.TextBox PlainTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label PlainTextLabel;
        private System.Windows.Forms.Label CipherTextLabel;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.RadioButton RailFenceRBtn;
        private System.Windows.Forms.RadioButton ColumnRBtn;
        private System.Windows.Forms.RadioButton VigenerRBtn;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToEncryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToDecryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem savePlainTextStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCipherTextStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

