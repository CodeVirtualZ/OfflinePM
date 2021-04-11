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
    public partial class Frm_Register : Form
    {
        public Frm_Register()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(Application.StartupPath + @"\Config.opm"))
                {
                    var key = "4622c3067f0d4b8c903717443ca0b4ee";
                    var encryptedString = AesOperation.EncryptString(key, txt_createpwd.Text);
                    sw.WriteLine(encryptedString);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch
            {

            }
            finally
            {
                Frm_Main main = new Frm_Main();
                main.Show();
                this.Hide();
            }
            
        }

        private void Frm_Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
