using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hasil.ReadOnly = true;

            operasi.Items.Add("Penambahan");
            operasi.Items.Add("Pengurangan");
            operasi.Items.Add("Perkalian");
            operasi.Items.Add("Pembagian");
            operasi.SelectedItem = "Penambahan";
        }

        static double penambahan (double a, double b)
        {
            return a + b;
        }
        static double pengurangan(double a, double b)
        {
            return a - b;
        }
        static double perkalian(double a, double b)
        {
            return a * b;
        }
        static double pembagian(double a, double b)
        {
            return a / b;
        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(angka1.Text);
            var b = Convert.ToDouble(angka2.Text);
            string pilihOperasi = operasi.Text;

            if (pilihOperasi =="Penambahan")
            {
                hasil.Text = Convert.ToString(penambahan(a, b));
            }

            else if (pilihOperasi == "Pengurangan")
            {
                hasil.Text = Convert.ToString(pengurangan(a, b));
            }

            else if (pilihOperasi == "Perkalian")
            {
                hasil.Text = Convert.ToString(perkalian(a, b));
            }

            else
            {
                hasil.Text = Convert.ToString(pembagian(a, b));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
