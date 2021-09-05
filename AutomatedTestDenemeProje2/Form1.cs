using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedTestDenemeProje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi1 = 0, sayi2 = 0;

        #region Methods
        private void initSayi(out int sayi1, out int sayi2)
        {
            sayi1 = int.Parse(tbxSayi1.Text.Trim());
            sayi2 = int.Parse(tbxSayi2.Text.Trim());
        }

        private int topla(int sayi1, int sayi2)
        {
            int result = 0;
            result = sayi1 + sayi2;
            return result;
        }

        private int cikar(int sayi1, int sayi2)
        {
            int result = 0;
            result = sayi1 - sayi2;
            return result;
        }

        private int carp(int sayi1, int sayi2)
        {
            int result = 0;
            result = sayi1 * sayi2;
            return result;
        }

        private int bol(int sayi1, int sayi2)
        {
            int result = 0;
            result = sayi1 / sayi2;
            return result;
        }
        #endregion

        #region Events
        private void btnArti_Click(object sender, EventArgs e)
        {
            try
            {
                initSayi(out sayi1, out sayi2);
                tbxSonuc.Text = (topla(sayi1, sayi2)).ToString();
                pictureBox1.Image = ımageList1.Images[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        private void btnEksi_Click(object sender, EventArgs e)
        {
            try
            {
                initSayi(out sayi1, out sayi2);
                tbxSonuc.Text = (cikar(sayi1, sayi2)).ToString();
                pictureBox1.Image = ımageList1.Images[0];//HATA-1
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            try
            {
                initSayi(out sayi1, out sayi2);
                tbxSonuc.Text = (carp(sayi1, sayi2)).ToString();
                pictureBox1.Image = ımageList1.Images[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            try
            {
                initSayi(out sayi1, out sayi2);
                tbxSonuc.Text = (carp(sayi1, sayi2)).ToString();//HATA-2
                pictureBox1.Image = ımageList1.Images[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


    }
}
