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

namespace TI4
{
    public partial class DSAForm : Form
    {
        public DSAForm()
        {
            InitializeComponent();
           
            Directory.SetCurrentDirectory(@"../../../");
        }
        private string FileName;

        private void BtnFile_Click(object sender, EventArgs e)
        {
            if (openFileDlg.ShowDialog()==DialogResult.OK)
            {
                FileName = openFileDlg.FileName;
                BtnCheckSignature.Enabled = true;
                BtnSignSignature.Enabled = true;
            }
        }

        private void BtnSignSignature_Click(object sender, EventArgs e)
        {  
            try
            {
       
                HashTB.Text = "";
                DigestTB.Text = "";
                long q = long.Parse(qTB.Text);
                long p = long.Parse(pTB.Text);
                long h = long.Parse(hTB.Text);
                long x = long.Parse(xTB.Text);
                long k = long.Parse(kTB.Text);
                
                DSASignature.SignSignature(q, p, h, x, k, FileName, out long r, out long s, out long H);
                HashTB.Text = H.ToString();
                DigestTB.Text = $"r = {r} s = {s}";
             }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void BtnCheckSignature_Click(object sender, EventArgs e)
        {
            try
            {
                HashTB.Text = "";
                DigestTB.Text = "";
                long q = long.Parse(qTB.Text);
                long p = long.Parse(pTB.Text);
                long h = long.Parse(hTB.Text);
                long x = long.Parse(xTB.Text);
                long k = long.Parse(kTB.Text);
                long r = 0, s = 0, H = 0;
                MessageBox.Show(DSASignature.CheckSignature(FileName, q, p,h,x,k,ref H, ref r, ref s),"Info", MessageBoxButtons.OK);
                if (H != 0)
                {
                    HashTB.Text = H.ToString();
                    DigestTB.Text = $"r = {r} s = {s}";
                }
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
