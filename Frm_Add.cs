using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfflinePM
{
    public partial class Frm_Add : Form
    {
        public Frm_Add()
        {
            InitializeComponent();
        }

        
        private void btn_add_Click(object sender, EventArgs e)
        {
            int duplicate = 0;
            try
            {
                using (StreamReader sr = File.OpenText(Application.StartupPath + @"\Data.opm"))
                {
                    string[] lines = sr.ReadToEnd().Split(new[] { Environment.NewLine },StringSplitOptions.None);
                    foreach(string str in lines)
                    {
                        string[] real_str = str.Split("|");
                        if(real_str[0] == txt_addweb.Text)
                        {
                            duplicate = 1;
                        }
                        sr.Close();
                    }
                }
            }
            catch
            {

            }
            finally
            {
                if (duplicate != 0)
                {
                    MessageBox.Show("duplicate data");
                    
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(Application.StartupPath + @"\Data.opm"))
                    {
                        var key = "843f0736881b4c8e95b5c4459105be0b";
                        string plaintext = txt_addweb.Text + "|" + txt_adduser.Text + "|" + txt_addpwd.Text;
                        var encryptedString = AesOperation.EncryptString(key, plaintext);
                        sw.WriteLine(encryptedString);
                    }
                    this.Close();
                }
            }
        }
    }
}
