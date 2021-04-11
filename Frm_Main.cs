using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OfflinePM
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            
        }
        public string master_pass = string.Empty;
        private string key = "843f0736881b4c8e95b5c4459105be0b";
        private void btn_copyuser_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_user.Text);
        }
        private void btn_showpwd_Click(object sender, EventArgs e)
        {
            if(txt_pass.PasswordChar == '●')
            {
                txt_pass.PasswordChar = '\0';
                btn_showpwd.Text = "Hide";
            }
            else
            {
                txt_pass.PasswordChar = '●';
                btn_showpwd.Text = "Show";
            }
            
        }
        private void btn_copypwd_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_pass.Text);
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Add")
            {
                Frm_Add add = new Frm_Add();
                add.Show();
            }
            if (e.ClickedItem.Text == "Change Master Password")
            {
                MessageBox.Show("Coming Soon...");
            }
            if (e.ClickedItem.Text == "Refresh")
            {
                try
                {
                    listBox1.Items.Clear();
                    using (StreamReader sr = new StreamReader(Application.StartupPath + @"\Data.opm"))
                    {
                        string[] get_service = sr.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                        foreach (string str in get_service)
                        {
                            var decryptedString = AesOperation.DecryptString(key, str);
                            string[] real_str = decryptedString.Split("|");
                            listBox1.Items.Add(real_str[0]);
                        }
                        sr.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Application.StartupPath + @"\Data.opm"))
                {
                    string[] get_service = sr.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                    var decryptedString = new List<string>();
                    foreach (string str in get_service)
                    {
                        decryptedString.Add(AesOperation.DecryptString(key, str));
                    }
                    int num = listBox1.SelectedIndex;
                    string[] real_str = decryptedString[num].Split("|");
                    txt_user.Text = real_str[1];
                    txt_pass.Text = real_str[2];
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void Frm_Main_Shown(object sender, EventArgs e)
        {
            if (master_pass==string.Empty)
            {
                this.Hide();
                Frm_Login login = new Frm_Login();
                login.Show();
            }
            try
            {
                listBox1.Items.Clear();
                using (StreamReader sr = new StreamReader(Application.StartupPath + @"\Data.opm"))
                {
                    string[] get_service = sr.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                    foreach (string str in get_service)
                    {
                        var decryptedString = AesOperation.DecryptString(key, str);
                        string[] real_str = decryptedString.Split("|");
                        listBox1.Items.Add(real_str[0]);
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
