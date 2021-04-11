using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfflinePM
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        private void btn_enter_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Application.StartupPath + @"\Config.opm"))
                {
                    var key = "4622c3067f0d4b8c903717443ca0b4ee";
                    var decryptedString = AesOperation.DecryptString(key, sr.ReadLine());
                    if(txt_pwd.Text == decryptedString)
                    {
                        Frm_Main main = new Frm_Main();
                        main.master_pass = decryptedString;
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed!");
                    }
                    sr.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Login_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\Config.opm"))
            {
                MessageBox.Show("First time? you need to create master password!");
                Frm_Register res = new Frm_Register();
                res.Show();
                this.Hide();
            }
        }
    }
}
