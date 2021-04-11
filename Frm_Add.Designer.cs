
namespace OfflinePM
{
    partial class Frm_Add
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
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_addpwd = new System.Windows.Forms.TextBox();
            this.txt_adduser = new System.Windows.Forms.TextBox();
            this.txt_addweb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(74, 98);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(237, 23);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add Data";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_addpwd
            // 
            this.txt_addpwd.Location = new System.Drawing.Point(74, 69);
            this.txt_addpwd.Name = "txt_addpwd";
            this.txt_addpwd.Size = new System.Drawing.Size(237, 23);
            this.txt_addpwd.TabIndex = 12;
            // 
            // txt_adduser
            // 
            this.txt_adduser.Location = new System.Drawing.Point(74, 40);
            this.txt_adduser.Name = "txt_adduser";
            this.txt_adduser.Size = new System.Drawing.Size(237, 23);
            this.txt_adduser.TabIndex = 11;
            // 
            // txt_addweb
            // 
            this.txt_addweb.Location = new System.Drawing.Point(74, 11);
            this.txt_addweb.Name = "txt_addweb";
            this.txt_addweb.Size = new System.Drawing.Size(237, 23);
            this.txt_addweb.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Website:";
            // 
            // Frm_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 132);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_addpwd);
            this.Controls.Add(this.txt_adduser);
            this.Controls.Add(this.txt_addweb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Add";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add data to OfflinePM";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_addpwd;
        private System.Windows.Forms.TextBox txt_adduser;
        private System.Windows.Forms.TextBox txt_addweb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}