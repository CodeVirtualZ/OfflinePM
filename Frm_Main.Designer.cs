
namespace OfflinePM
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_copyuser = new System.Windows.Forms.Button();
            this.btn_showpwd = new System.Windows.Forms.Button();
            this.btn_copypwd = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(6, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 169);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_copyuser);
            this.groupBox2.Controls.Add(this.btn_showpwd);
            this.groupBox2.Controls.Add(this.btn_copypwd);
            this.groupBox2.Controls.Add(this.txt_pass);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_user);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(225, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // btn_copyuser
            // 
            this.btn_copyuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_copyuser.Location = new System.Drawing.Point(6, 69);
            this.btn_copyuser.Name = "btn_copyuser";
            this.btn_copyuser.Size = new System.Drawing.Size(195, 23);
            this.btn_copyuser.TabIndex = 6;
            this.btn_copyuser.Text = "Copy";
            this.btn_copyuser.UseVisualStyleBackColor = true;
            this.btn_copyuser.Click += new System.EventHandler(this.btn_copyuser_Click);
            // 
            // btn_showpwd
            // 
            this.btn_showpwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showpwd.Location = new System.Drawing.Point(6, 171);
            this.btn_showpwd.Name = "btn_showpwd";
            this.btn_showpwd.Size = new System.Drawing.Size(195, 23);
            this.btn_showpwd.TabIndex = 5;
            this.btn_showpwd.Text = "Show";
            this.btn_showpwd.UseVisualStyleBackColor = true;
            this.btn_showpwd.Click += new System.EventHandler(this.btn_showpwd_Click);
            // 
            // btn_copypwd
            // 
            this.btn_copypwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_copypwd.Location = new System.Drawing.Point(6, 142);
            this.btn_copypwd.Name = "btn_copypwd";
            this.btn_copypwd.Size = new System.Drawing.Size(195, 23);
            this.btn_copypwd.TabIndex = 4;
            this.btn_copypwd.Text = "Copy";
            this.btn_copypwd.UseVisualStyleBackColor = true;
            this.btn_copypwd.Click += new System.EventHandler(this.btn_copypwd_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(6, 113);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '●';
            this.txt_pass.ReadOnly = true;
            this.txt_pass.Size = new System.Drawing.Size(195, 23);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(6, 40);
            this.txt_user.Name = "txt_user";
            this.txt_user.ReadOnly = true;
            this.txt_user.Size = new System.Drawing.Size(195, 23);
            this.txt_user.TabIndex = 1;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Checked = true;
            this.fileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fileToolStripMenuItem.Text = "Add";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Checked = true;
            this.helpToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.helpToolStripMenuItem.Text = "Refresh";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 20);
            this.toolStripMenuItem1.Text = "Change Master Password";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 232);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Offline Password Manager v1.0";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.Shown += new System.EventHandler(this.Frm_Main_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_showpwd;
        private System.Windows.Forms.Button btn_copypwd;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_copyuser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}